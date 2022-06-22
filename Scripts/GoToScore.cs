using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScore : MonoBehaviour
{
    public void Select()
    {
        SceneManager.LoadScene("ScoreTable");
    }

}
