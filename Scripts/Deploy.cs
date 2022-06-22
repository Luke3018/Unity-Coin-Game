using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy : MonoBehaviour
{
    public GameObject Coins;
    public float respawnTime = 1.2f;
    private Vector2 screenBound;
    private int Rate;

    void Start()
    {
        Rate = PlayerPrefs.GetInt("First");
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CoinFall());
    }

    private void spawnCoins()
    {
        GameObject a = Instantiate(Coins) as GameObject;
        a.transform.position = new Vector2(Random.Range(-80.0f, 80.0f), screenBound.y * 1);
    }

    IEnumerator CoinFall()
    {
        Rate = PlayerPrefs.GetInt("First");
        while (true)
        {
            if (Rate >= 60)
            {
                respawnTime = 0.5f;
                yield return new WaitForSeconds(respawnTime);
                spawnCoins();
            }
            else if (Rate >= 120)
            {
                respawnTime = 0.2f;
                yield return new WaitForSeconds(respawnTime);
                spawnCoins();
            }  else
            {
                yield return new WaitForSeconds(respawnTime);
                spawnCoins();
            }
            
            
        }
    }
}
