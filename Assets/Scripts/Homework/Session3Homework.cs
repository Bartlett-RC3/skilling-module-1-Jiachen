using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{

    public GameObject cubePrefab;
    public float moveDirection ;
    public Material color;




    void Start()
    {
        Instantiate(cubePrefab, this.transform);
    }

   
    void Update()
    {
      
        this.transform.Translate(0,0,moveDirection);


        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(new Vector3(0, 3, 0));
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            color.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}