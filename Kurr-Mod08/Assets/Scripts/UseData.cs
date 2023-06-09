using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data; 

    //public GameObject myCube;//prefab
    int rowCount; //variable 

    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;

    public object tempObj;
    public float tempFloat;

    


    void Awake()
    {

        data = CSVReader.Read("xc02DataOnly");//udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            print("xco2 " + data[i]["xco2"] + " " );
        }
        rowCount = 0;

    }//end Awake()

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", startDelay, timeInterval);

    }//end Start()

    // Update is called once per frame
    /*void Update()
    {
        for (var i = 0; i < data.Count; i++)
        {
            object xco2 = data[i]["xco2"];//get age data
            gameObject.transform.localScale = new Vector3((float)xco2, (float)xco2, (float)xco2);
            //cubeCount += (int)xco2;//convert age data to int and add to cubeCount
            //Debug.Log("cubeCount " +cubeCount);
        }
       

    }*/  //end Update() 

    void SpawnObject()
    {
        tempObj = (data[rowCount]["xco2"]);
        tempFloat = System.Convert.ToSingle(tempObj);
<<<<<<< HEAD
       
=======
        //Debug.Log(tempFloat = Remap(tempFloat, from1, to1, from2, to2));
>>>>>>> b829a1ef067568337bf49d96969ba613fd19302d
        
        rowCount++;

        transform.localScale = new Vector3(tempFloat, tempFloat, tempFloat);
        Debug.Log("The tempFloat = " + tempFloat);
        Debug.Log("Count = " + rowCount);
    }

    
}

