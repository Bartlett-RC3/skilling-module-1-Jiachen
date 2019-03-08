using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Session4_Jiachen : MonoBehaviour
{
    public GameObject prefabReference;
    IEnumerator createPrefabs;

	// Use this for initialization
	void Start ()
    {
		//how do we instantiate a new prefab?_give a object position,rotation and parent
        Vector3 prefabPosition=new Vector3(UnityEngine.Random.Range(-10,10),UnityEngine.Random.Range(-10,10), UnityEngine.Random.Range(-10, 10));
        Quaternion prefabRotation = Quaternion.identity;
        for (int i = 0; i < 10; i++)
        {
            GameObject myPrefab = Instantiate(prefabReference, prefabPosition, prefabRotation);
            foreach (Transform child in myPrefab.transform)
            {
                child.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);//sphere is child of cube
            }
            myPrefab.GetComponent<MeshRenderer>().material.color=new Color(0,1,0);
        }

        createPrefabs = DropPrefabFromHeight();


    }

    private void Instantiate()
    {
        throw new NotImplementedException();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    StartCoroutine(createPrefabs);
        Debug.Log(Time.time);
	    if (Time.time>5)
	    {
	        StopCoroutine(createPrefabs);
            StopAllCoroutines();
	    }
	}

    //implement the coroutine
    IEnumerator DropPrefabFromHeight()
    {
        while (true)
        {
            Vector3 prefabPosition=new Vector3(UnityEngine.Random.Range(-10,10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRotation=new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90),1);
            Instantiate(prefabReference, prefabPosition, prefabRotation);
            yield return new WaitForSeconds(5);
        }
    }
}
