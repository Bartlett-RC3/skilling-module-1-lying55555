using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Session2Homework : MonoBehaviour
{
    // Start is called before the first frame update
    private string[] layer =
    {
        "Roof Deck", "Protection Board", "Waterproof Membrane", "Insulation", "Drainage Layer", "Filter Fabric",
        "Growing Medium", "Plants"
    };
   
    void Start()

    {
        // i.Shorthand conditions

       for (int i =0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log( i + " is divisible by 2");
            }

            if (i % 3 == 0)
            {
                Debug.Log(i + " is divisible by 3");
                
            }
        }        

        bool question1Anwer = true; 
        bool question2Anwer = false;
        bool question3Anwer = true;
        bool question4Anwer = false;

       if (question1Anwer || question2Anwer || question3Anwer || question4Anwer)
       {
           Debug.Log("One of the answer is true");
       }

        //ii.For and foreach loops

        for (int counter = 0; counter < layer.Length; counter++)
        {
            Debug.Log("The current material at layer " + counter);
            Debug.Log(layer[counter]);
        }

        foreach (string currentLayer in layer)
        {
            Debug.Log("Going over the layer of green roof with " +currentLayer );

        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
