using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void Select()
    {
        SceneManager.LoadScene("GameScene");

        PlayerPrefs.SetInt("First", 0);
        PlayerPrefs.SetInt("Second", 0);
        PlayerPrefs.SetInt("Third", 0);
        
        PlayerPrefs.SetString("FirstPlace", "");
        PlayerPrefs.SetString("SecondPlace", "");
        PlayerPrefs.SetString("ThirdPlace", "");
    }
}
