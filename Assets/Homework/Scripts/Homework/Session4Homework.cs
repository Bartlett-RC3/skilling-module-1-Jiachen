using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour
{
    [SerializeField]private GameObject CubePrefab;
    private IEnumerator createPrefabs;
    private IEnumerator changeColors;
    [Range(0, 2)] [SerializeField] private float _speed=1f;

    private List<GameObject> Cubes=new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        createPrefabs = CreatePrefab();
        changeColors = ChangeColors();

        if (Time.time <= 20)
        {
            StartCoroutine(createPrefabs);
        }

        else if (Time.time > 20)
        {
            StopCoroutine(createPrefabs);
        }

        StartCoroutine(changeColors);

    }

    // Update is called once per frame
    void Update()
    {
    }

    //implement the coroutine
    IEnumerator CreatePrefab()
    {
        while (true)
        {
            Vector3 prefabPosition = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRotation = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), 1);
            GameObject myPrefab = Instantiate(CubePrefab, prefabPosition, prefabRotation);
            myPrefab.GetComponent<MeshRenderer>().material.color=new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            yield return new WaitForSeconds(_speed);
            Cubes.Add(myPrefab);
            Debug.Log("counts: "+Cubes.Count);
        }
    }

    IEnumerator ChangeColors()
    {
        while (true)
        {
            foreach (var cube in Cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.value,
                    UnityEngine.Random.value, UnityEngine.Random.value);
            }
            yield return new WaitForSeconds(1);
        }
    }


}
