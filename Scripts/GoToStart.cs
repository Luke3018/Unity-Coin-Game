using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStart : MonoBehaviour
{
    public void Select()
    {
        SceneManager.LoadScene("StartMenu");
    }


}
