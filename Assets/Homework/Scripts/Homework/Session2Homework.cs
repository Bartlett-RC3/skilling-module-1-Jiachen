using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ADog;


public class Session2Homework : MonoBehaviour
{

    // Variables
    public int number1 = 10;
    public int number2 = 20;


    public bool someBool = false;
    public int myNumber = 2;
    public string someName = "name";

    public string[] gameNames = { "DOTA", "PUBG", "LOL", "Final Fantasy" };

    List<Dog> dog = new List<Dog>();

  

    void Start()
    {
        Dog wangcai = new Dog(2,0.6f,1.2f,true,"wangcai");
        Debug.Log(wangcai.GetNickName());


        if (number1 < number2)
        {
            Debug.Log("Number1 is smaller than number2");
        }
        else
        {
            Debug.Log("Number1 is greater than number2");
        }


        // Conditionals

        // Normal if statement
        if (myNumber == 2)
        {
            Debug.Log("Your number is equal to 2.");
        }
        else
        {
            Debug.Log("Your number is not equal to 2.");
        }




        if (number1 < number2 && someBool == true)
        {
            Debug.Log("Answer to both question is yes");
        }





        if (number1 < number2)
        {
            if (someBool == true)
            {
                Debug.Log("Answer to both question is yes");
            }
        }



        if (number1 < number2 || someBool == true)
        {
            Debug.Log("at least one question is yes");
        }

        if ((number1 < number2 || someBool == true) && (someBool == true && someName == "name"))
        {
            Debug.Log("Simply please because it is too confusing");
        }


        // Shorthand if statement
        Debug.Log((number1 < number2) ? "smaller" : "greater");

        //Navigate data: for loop
        for (int i = 0; i < gameNames.Length; i++)
        {
            Debug.Log("A tutor is: " + gameNames[i]);
        }

        foreach (var gameName in gameNames)
        {
            Debug.Log("A tutor is: " + gameName);
        }

    }

   
    // Update is called once per frame
    void Update()
    {
       
    }
}

