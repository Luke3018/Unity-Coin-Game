using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHow : MonoBehaviour
{
    public void Select()
    {
        SceneManager.LoadScene("About");
    }
}
