//Refrences 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

//Where code lives 
public class Session1_Jiachen: MonoBehaviour
{

    // 1.Variables
    // Scope -- Type -- Name -- Value

    //public/private -- ...

    // Numbers
    int myInteger = 22;
    int maxInteger  = int.MaxValue;
    int minInteger = int.MinValue;

    double myDouble = 11.11;
    double maxDouble = double.MaxValue;

    public float myFloat = 12.34f;
    

    public int myFirstIntegerNumber = 101; //make sure you end with ;
    float myFirstFloatNumber = 1.75f;
    decimal x = 1.324m;

    // Text
    //public string myFirstString = "My text is somewhere.";
    string myString = "It's gonna be a super exciting week!";


    // Logical variable
    bool myFirstBoolean = true;
    bool myBoolean = !true;

    // 2.Data structures
    // Scope -- Type -- Values(can take in many values)

    // 2.a.Arrays(fixed size)
    public int[] myIntegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myTwentyElementsFloatArray = new float[20];

    public int[] myIntArray = new int[10]{1,2,4,5,3,5,6,7,8,9};
    public int[,] myTwoDimentioalArray = new int[3,5];

    // 2.b.Lists(dynamic size)
    public List<int> myIntegerList = new List<int>();

    // 2.c.Dictionary create some sort of rules that ...
    //                what is the logic that i organize sth ...
    //                Dictionary<string,string>          
    Dictionary<string,string> movingAnimals=new Dictionary<string, string>();


    // 3.Functions
    // Scope -- Type -- Variables -- Body (Instructions)

    // Use this for initialization
    void Start ()
    {
        movingAnimals.Add("flying","eagle");
        movingAnimals.Add("flying","parrot");
        movingAnimals.Add("climbing","monkey");
        movingAnimals.Add("climbing","panda");
        movingAnimals.Add("walking","dog");
        if (movingAnimals.ContainsKey("climbing"))
        {
            Debug.Log("A climbing animal is: "+movingAnimals.Values);
        }

        //Array adding value
        myIntArray[2] = 300;
        //Array retrive value
        Debug.Log(myIntArray[1].ToString());

        //Debug.Log("Addition of 5 and 3 is: " + AddtionOfNumbers(5,3));
        //myTwentyElementsFloatArray[2] = 3.2f;
        //myTwentyElementsFloatArray[3] = 5.6f;
        //myTwentyElementsFloatArray[4] = 9.2f;

        //List add numbers: u can only add numbers at the end of the list
        myIntegerList.Add(1234);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

        //List retrive value
        Debug.Log(myIntegerList[2].ToString());
        Debug.Log(myIntegerList[myIntegerList.Count-1].ToString());

        //clearing the list
        myIntegerList.Clear();
    }

    // Update is called once per frame
    void Update ()
	{
        Debug.Log("Hello world!");
	}


    //number addition function
    //scole -- type(void, int, float, ...) -- variable -- body(instuctions)
    public float NumberAddition(float a,float b)
    {
        return a + b;
    }

    public void PrintSomeNumbers()
    {
        Debug.Log(myIntegerList[0]);
        Debug.Log(myIntArray[0]);
        Debug.Log(myInteger);
    }

    public int AddtionOfNumbers(int number1, int number2)
    {
        int addtionResult = number1 + number2;
        return addtionResult;
    }
}
