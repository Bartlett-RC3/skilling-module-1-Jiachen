using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject light;
    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;


    //happens whenever u use unity
    //private void Awake()
    //{

    //}

    // Use this for initialization (just happens when press "play" button)
    // Reset
    void Start()
    {
        for (int i = 0; i < gridX; i++)
        {
            for (int j = 0; j < gridY; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform);
            }

        }
    }

    // Update is called once per frame
    //computers measure time in frames
    void Update()
    {
        //Time
        Debug.Log("This computer can render a frame in: " + Time.deltaTime);
        Debug.Log("Since I started playing the game this amount of time has passed: " + Time.realtimeSinceStartup);
        Debug.Log("Computer has counted this amount of frames: " + Time.frameCount);


        //Transform
        //move children gameobject in x axis
        foreach (Transform child in this.transform)
        {
            Random random;
            //child.Translate(Random.value,0,0);
            child.Translate(0, 0, Random.Range(-0.1f, 0.1f));
        }

        //ROtation
        //
        foreach (Transform child in this.transform)
        {
            child.RotateAroundLocal(Vector3.up, Random.Range(-1f, 1f));
        }

        //Scale
        //
        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1));
        }

        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            originalScale[i] = transform.GetChild(i).localScale;
        }


        //keyboard input
        if (Input.GetKey(KeyCode.Space))//getkeydown->getkey : continual action
        {
            //if i have pressed space make temporary the cube large!
            //record the cubes original scale    
            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 5f;
            }
        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }
        }


        //mouse pressed(0-left;1-right;2-middle)
        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        }
    }
}