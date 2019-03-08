using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_raycasting_Jiachen : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//ray casting steps

        //step1:creat ray
	    Vector3 raycastingDirection = transform.forward;

        //step2:see what object is in front of me
	    RaycastHit objectInFront;


	    if (Physics.Raycast(transform.position,raycastingDirection,out objectInFront))
	    {
	        Debug.Log("Object in front is: "+ objectInFront.transform.name);
	        objectInFront.transform.GetComponent<ListenScript>().seen = true;//responsibility of color the cube is cube itself,change the behavir of the cube
        }
	}
}
