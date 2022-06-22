using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Absorb : MonoBehaviour
{   
    //Global public variable declaration
    public GameObject Coin;
    public GameObject Enemy;
    public GameObject LeftB;
    public GameObject RightB;
    public GameObject Name;
    public AudioSource Ding;
    public AudioSource LifeLost;
    public AudioSource Chest;
    public Text score;
    public TMP_Text Lives;
    public TMP_Text GameOver;

    public SpriteRenderer Player;

    //Global private variable declaration
    private int scoreValue = 0;
    private int livesLeft = 3;
    private int One = 0;
    private int two = 0;
    private int third = 0;
    private int four = 0;
    private int five = 0;
    private int six = 0;
    private int seven = 0;


    private void start()
    {
        //set up and assign audioSource
        Ding.GetComponent<AudioSource>();
        LifeLost.GetComponent<AudioSource>();
        Chest.GetComponent<AudioSource>();

        //Hide GameOver text until it is needed
        GameOver.GetComponent<TMP_Text>().enabled = false;
    }

    private void Update()
    {
        //Hide Player name inputBox until needed 
        Name.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D hit)
    {


        //Remove object from scene when collided with player
        Destroy(hit.gameObject);
       

        if (hit.gameObject.tag == "coin")
        {
            //if player collides with coin call Add method
             Add();
        }

        if (hit.gameObject.tag == "Enemy")
        {
            //if player collides with enemy call Loss method
            Loss();
        }

        if (hit.gameObject.tag == "Bonus")
        {
            //if player collides with chest call ExtraPoints method
            ExtraPoints();
        }
    }

    private void Add()
    {
        //play sound effect for coin (single)
        Ding.Play();

        //Load score values from save location
        One = PlayerPrefs.GetInt("First");
        two = PlayerPrefs.GetInt("Second");
        third = PlayerPrefs.GetInt("Third");
        four = PlayerPrefs.GetInt("Four");
        five = PlayerPrefs.GetInt("Five");
        six = PlayerPrefs.GetInt("Six");
        seven = PlayerPrefs.GetInt("Seven");

        //add 1 to score, save in location, display score in textbox
        scoreValue++;
        PlayerPrefs.SetInt("Points", scoreValue);
        score.text = scoreValue.ToString();
        
        //Assign score to be first/ second/ third to be accessed later in leaderboard scene
        if (scoreValue > One)
        {
           PlayerPrefs.SetInt("First", scoreValue);

        } else if (scoreValue < One && scoreValue > two)
        {
            PlayerPrefs.SetInt("Second", scoreValue);

        } else if (scoreValue > third && scoreValue < two)
        {
            PlayerPrefs.SetInt("Third", scoreValue);
        }
        else if (scoreValue > four && scoreValue < third)
        {
            PlayerPrefs.SetInt("Four", scoreValue);
        }
        else if (scoreValue > five && scoreValue < four)
        {
            PlayerPrefs.SetInt("Five", scoreValue);
        }
        else if (scoreValue > six && scoreValue < five)
        {
            PlayerPrefs.SetInt("Six", scoreValue);
        }
        else if (scoreValue > seven && scoreValue < six)
        {
            PlayerPrefs.SetInt("Seven", scoreValue);
        }
    }

    private void Loss()
    {
        //play sound effect for life lost (single)
        LifeLost.Play();

        //calls the method to fade charater
        StartCoroutine(FadeOut(GetComponent<SpriteRenderer>(), 2f));

        //take away 1 life, output remaining to textbox 
        livesLeft--;
        Lives.text = "Lives: " + livesLeft.ToString();  

        if (livesLeft <= 0)
        {   
            //Remove player from scene, unhide GameOver text 
            Destroy(this.gameObject);
            GameOver.GetComponent<TMP_Text>().enabled = true;
            GameOver.text = "Game Over";

            GetPlayerName();

            //Hide buttons as game is over (stop game running in background)
            LeftB.gameObject.SetActive(false);
            RightB.gameObject.SetActive(false);

        }
    }

    private void ExtraPoints()
    {
        Chest.Play();

        //Randomize score of chest 
        scoreValue += Random.Range(30, 60);
    }

    public void GetPlayerName()
    {
        //Unhide inputbox for user to enter name for scoreboard
        Name.SetActive(true);
    }

    IEnumerator FadeOut(SpriteRenderer Player, float duration)
    {
        Color startColor = Player.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0);
        float time = 0;
        while (time < duration)
        {
            time += Time.deltaTime;
            Player.color = Color.Lerp(startColor, endColor, time / duration);
            yield return null;
            StartCoroutine(FadeIn(GetComponent<SpriteRenderer>(), 2f));
        }
    }

    IEnumerator FadeIn(SpriteRenderer Player, float duration)
    {
        Color startColor = Player.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1);
        float time = 0;
        while (time < duration)
        {
            time += Time.deltaTime;
            Player.color = Color.Lerp(startColor, endColor, time / duration);
            yield return null;
        }
    }

}


