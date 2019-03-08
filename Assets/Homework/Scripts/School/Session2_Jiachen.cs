// Session 2: Conditionals, Loops and Classes 
// UCL RC3 12Nov2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jiachen;

public class Session2_Jiachen : MonoBehaviour
{

    // Variables
    public int number1 = 10;
    public int number2 = 20;


    public bool someBool = false;
    public int myNumber = 2;
    public string someName = "name";

    public string[] tutorNames = {"Octavian", "Dave", "Tyson", "Jordi", "Panos"}; 

    List<CustomObject> aCustomObjects = new List<CustomObject>();

    //public bool questionTime = true;
    //int myVariableQuestionTime;

    //string[] fruits = { "banana", "apple", "mango", "blueberry" };
    //List<int> evenNumbers = new List<int>();
    //int[] evenNumbersSmart = new int[10];

    ////List to store humans
    //List<Human> rc3Tutors = new List<Human>();

    //// Use this for initialization
    void Start()
    {
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
        for (int i = 0; i < tutorNames.Length; i++)
        {
            Debug.Log("A tutor is: " + tutorNames[i]);
        }

        foreach (var tutorName in tutorNames)
        {
            Debug.Log("A tutor is: " + tutorName);
        }

    }

        // Short if statement
        //    if (questionTime)
        //    {
        //        Debug.Log("Question time is true");
        //    }
        //    else
        //    {
        //        Debug.Log("Question time is false");
        //    }

        //    // Variable name is equal to either 1 or 0 based on the value of questionTime
        //    myVariableQuestionTime = (questionTime == true) ? 1 : 0;
        //    Debug.Log("The value of myVariableQuestionTime is: " + myVariableQuestionTime);

        //    // Question concatenation
        //    if (myNumber == 2 && questionTime == false)
        //    {
        //        Debug.Log("Your number is 2 and QT is false");
        //    }

        //    // Question or statement
        //    if (myNumber == 2 || questionTime == false)
        //    {
        //        Debug.Log("It may be that your number is 2 or it may be that QT is false");
        //    }

        //    // Loops

        //    // For loop statement (start value, how this ends, incrementation)
        //    for (int i = 0; i < fruits.Length; i = i + 1)
        //    {
        //        Debug.Log("Fruit at position " + i + "is " + fruits[i]);
        //    }

        //    // Add 10 even numbers from 0 to 20
        //    for (int i =0; i<20; i = i+2)
        //    {
        //        evenNumbers.Add(i);
        //        evenNumbersSmart[i / 2] = i;
        //    }

        //    // Print the list
        //    for(int i=0; i<evenNumbers.Count; i++) // i = i + 1, i++
        //    {
        //        Debug.Log("Number is: " + evenNumbers[i]);
        //    }

        //    // Add 100 numbers to list and print the numbers that are divisible by 5
        //    List<int> myOneHundredNumbers = new List<int>();
        //    for(int i = 0; i<=100; i++)
        //    {
        //        myOneHundredNumbers.Add(i);
        //    }

        //    // The smart way
        //    for(int i = 0; i < myOneHundredNumbers.Count; i = i + 5)
        //    {
        //        Debug.Log("Numbers divisible by 5: " + myOneHundredNumbers[i]);
        //    }

        //    // The less smart way
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        if (i%5 == 0)
        //        {
        //            Debug.Log("Numbers divisible by 5: " + myOneHundredNumbers[i]);
        //        }
        //    }

        //    // While loop
        //    List<int> oddNumbers = new List<int>();
        //    int counter = 1;
        //    while(counter < 100)
        //    {
        //        oddNumbers.Add(counter);
        //        counter = counter + 2;
        //    }
        //    for(int i = 0; i < oddNumbers.Count; i++)
        //    {
        //        Debug.Log("Odd number : " + oddNumbers[i]);
        //    }

        //    // Create the tutors
        //    Human Octavian = new Human(31, 1.7f, true, "Octavian", "Gheorghiu");
        //    Human Tyson = new Human(34, 1.8f, true, "Tyson", "Hosmer");
        //    Human Dave = new Human(33, 1.75f, true, "Dave", "Reeves");

        //    rc3Tutors.Add(Octavian);
        //    rc3Tutors.Add(Tyson);
        //    rc3Tutors.Add(Dave);
        //}

        // Update is called once per frame
        void Update ()
	{
        //for(int i =0; i< rc3Tutors.Count; i++)
        //{
        //    Debug.Log(rc3Tutors[i].GetFirstName());
        //}
    }
}


