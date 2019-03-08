using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ray direction
        //Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward); // works when attached to camera
        Vector3 castedRayDirection = GetComponentInChildren<Transform>().forward; // works when attached to FPS

        // Store the object that is in front
        RaycastHit objectInFront;

        // Ray casting
        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
        {
            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It`s name is: " + objectInFrontName);
            objectInFront.transform.gameObject.transform.localScale=new Vector3(0f,0f,0f);
            
        }
    }


}
