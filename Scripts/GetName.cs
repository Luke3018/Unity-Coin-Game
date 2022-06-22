using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetName : MonoBehaviour
{
    private int One;
    private int two;
    private int third;
    private int four;
    private int five;
    private int six;
    private int seven;
    private int Points;

    public void Update()
    {
        Points = PlayerPrefs.GetInt("Points");
        One = PlayerPrefs.GetInt("First");
        two = PlayerPrefs.GetInt("Second");
        third = PlayerPrefs.GetInt("Third");
        four = PlayerPrefs.GetInt("Four");
        five = PlayerPrefs.GetInt("Five");
        six = PlayerPrefs.GetInt("Six");
        seven = PlayerPrefs.GetInt("Seven");

    }

    public void GetPlayerName(string s)
    {        
        
        
        Debug.Log(s);

        //One = PlayerPrefs.GetInt("First");
        //two = PlayerPrefs.GetInt("Second");
        //third = PlayerPrefs.GetInt("Third");

        //PlayerPrefs.SetString("FirstPlace", s);
        //PlayerPrefs.SetString("SecondPlace", s);
        //PlayerPrefs.SetString("ThirdPlace", s);

        if (Points >= One)
        {
            PlayerPrefs.SetString("FirstPlace", s);
        } else if (Points <= One && Points >= two)
        {
            PlayerPrefs.SetString("SecondPlace", s);
        } else if (Points >= third && Points <= two)
        {
            PlayerPrefs.SetString("ThirdPlace", s);
        }
        else if (Points >= four && Points <= third)
        {
            PlayerPrefs.SetString("FourthPlace", s);
        }
        else if (Points >= five && Points <= four)
        {
            PlayerPrefs.SetString("FivthPlace", s);
        }
        else if (Points >= six && Points <= five)
        {
            PlayerPrefs.SetString("SixthPlace", s);
        }
        else if (Points >= seven && Points <= six)
        {
            PlayerPrefs.SetString("SeventhPlace", s);
        }
  

    }

}


        
