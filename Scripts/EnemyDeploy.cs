using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeploy : MonoBehaviour
{
    //Global variable declarations
    public GameObject Enemy;
    private int Level;
    private float ERespawnTime = 1f;
    private Vector2 screenBound;

    void Start()
    {
        //load score from Game scene 
        Level = PlayerPrefs.GetInt("First");

        //find out the edges of the screen
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(EnemyFall());
    }

    private void spawnEnamy()
    {
        //create a clone gameobject of enemy 
        GameObject e = Instantiate(Enemy) as GameObject;
        //Randomly spawn enemy anywhere at the top of screen
        e.transform.position = new Vector2(Random.Range(-80.0f, 80.0f), screenBound.y * 1);
    }

    IEnumerator EnemyFall()
    {
        while (true)
        {
            if (Level >= 80)
            {
                //if score is high enough decreas respawn time of enemy (adds difficulty)
                ERespawnTime = Random.Range(0.5f, 4f);
                yield return new WaitForSeconds(ERespawnTime);
                spawnEnamy();
            } else
            {
                //normal respawn time for enemy 
                ERespawnTime = Random.Range(0.5f, 8f);
                yield return new WaitForSeconds(ERespawnTime);
                spawnEnamy();
            }

        }
    }
}
