using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PauseGame : MonoBehaviour
{
    public bool pause;
    public TMP_Text stopText;

    void Start()
    {
        pause = false;
        stopText.GetComponent<TMP_Text>().enabled = false;
    }


    void Update()
    {
    }

    public void onPause()
    {
        pause = !pause;

        if (pause)
        {
            Time.timeScale = 0;
            stopText.GetComponent<TMP_Text>().enabled = true;
        } else if (!pause)
        {
            Time.timeScale = 1;
            stopText.GetComponent<TMP_Text>().enabled = false;
        }
    }
}
