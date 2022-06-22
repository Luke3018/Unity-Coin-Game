using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //Public Global variable declarations 
    public Text HighScore;
    public Text SecondPlace;
    public Text ThirdPlace;
    public Text Four;
    public Text Five;
    public Text Six;
    public Text Seven;


    //Private Global variable declarations
    private int one;
    private int two;
    private int third;
    private int four;
    private int five;
    private int six;
    private int seven;
    private string FName;
    private string SName;
    private string TName;
    private string FOName;
    private string FIName;
    private string SIName;
    private string SEName;


    void Update()
    {
        //Load scores from saved location to appropriate position
        one = PlayerPrefs.GetInt("First");
        two = PlayerPrefs.GetInt("Second");
        third = PlayerPrefs.GetInt("Third");
        four = PlayerPrefs.GetInt("Four");
        five = PlayerPrefs.GetInt("Five");
        six = PlayerPrefs.GetInt("Six");
        seven = PlayerPrefs.GetInt("Seven");

        //Load name from saved location to appropriate position
        FName = PlayerPrefs.GetString("FirstPlace");
        SName = PlayerPrefs.GetString("SecondPlace");
        TName = PlayerPrefs.GetString("ThirdPlace");
        FOName = PlayerPrefs.GetString("FourthPlace");
        FIName = PlayerPrefs.GetString("FivthPlace");
        SIName = PlayerPrefs.GetString("SixthPlace");
        SEName = PlayerPrefs.GetString("SeventhPlace");

        if (one > two)
        {
            //Layout of leaderboard score for first place
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();

            //Layout of leaderboard name for first place
            /*
            FPlace.text = FName.ToString();
            SPlace.text = SName.ToString();
            TPlace.text = TName.ToString();
            */
        }  else if (two > one)
        {
            //if second place is higher redefine first place 
            //new layout of leaderboard
            HighScore.text = "1. " + " " + SName.ToString() + "       " + two.ToString();
            SecondPlace.text = "2. " + " " + FName.ToString() + "     " + one.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();

            /* 
             FPlace.text = SName.ToString();
             SPlace.text = FName.ToString();
             TPlace.text = TName.ToString();
            */
        }

        if (two > third)
        {
            //Layout of leaderboard for second place

            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();

            //Layout of leaderboard names for second place
            /*
            FPlace.text = FName.ToString();
            SPlace.text = SName.ToString();
            TPlace.text = TName.ToString();
            */
        } else if (third > two)
        {
            //if third is higher than second place redefine second place
            //new layoyt of leaderboard 

            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + TName.ToString() + "     " + third.ToString();
            ThirdPlace.text = "3. " + " " + SName.ToString() + "      " + two.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();

            /*
            FPlace.text = FName.ToString();
            SPlace.text = TName.ToString();
            TPlace.text = SName.ToString();
            */
        }
        else if (third > four)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();

        }
        else if (four > third)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + FOName.ToString() + "      " + four.ToString();
            Four.text = "4. " + " " + TName.ToString() + "      " + third.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (four > five)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (five > four)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FIName.ToString() + "      " + five.ToString();
            Five.text = "5. " + " " + FOName.ToString() + "      " + four.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (five > six)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (six > five)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + six.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + five.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (six > seven)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SIName.ToString() + "      " + six.ToString();
            Seven.text = "7. " + " " + SEName.ToString() + "      " + seven.ToString();
        }
        else if (seven > six)
        {
            HighScore.text = "1. " + " " + FName.ToString() + "       " + one.ToString();
            SecondPlace.text = "2. " + " " + SName.ToString() + "     " + two.ToString();
            ThirdPlace.text = "3. " + " " + TName.ToString() + "      " + third.ToString();
            Four.text = "4. " + " " + FOName.ToString() + "      " + four.ToString();
            Five.text = "5. " + " " + FIName.ToString() + "      " + five.ToString();
            Six.text = "6. " + " " + SEName.ToString() + "      " + seven.ToString();
            Seven.text = "7. " + " " + SIName.ToString() + "      " + six.ToString();
        }

    }
}
