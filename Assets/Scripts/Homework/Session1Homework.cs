using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{



    public string SayHello = "Nice to see you!";
    public int maximumPlayerNumer = 10;
    public float totalPay = 5.2f;

    public int[] playerAge=new int[5];

    public List<string> playerName = new List<string>();

    

// Use this for initialization
	void Start ()
    {
        totalPay = MultipltByTwo(totalPay);
        Debug.Log(totalPay);

        playerName.Add("Amy");
        playerName.Add("Bill");
        playerName.Add("Simon");
        Debug.Log(playerName.Count);

        IDictionary<string, string> playerCountry = new Dictionary<string, string>( );
        playerCountry.Add("China", "Beijing,Shanghai");
        playerCountry.Add("UK", "London,Birmingham");
        playerCountry.Add("Thailand", "Bangkok, ChiangMai");

        
        foreach (KeyValuePair<string , string> kvp in playerCountry)
            Debug.LogFormat("Key:{0}, Value:{1}", kvp.Key, kvp.Value);


    }

    
        float MultipltByTwo(float number)
        {
            float result;
            result = number * 2;
            return result;
        }

}