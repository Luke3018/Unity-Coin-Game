using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDeploy : MonoBehaviour
{
    public GameObject Chest;
    public float respawnTime = 5f;
    private Vector2 screenBound;

    void Start()
    {
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(OneTime());
    }

    private void spawnChest()
    {
        GameObject a = Instantiate(Chest) as GameObject;
        a.transform.position = new Vector2(Random.Range(-80.0f, 80.0f), screenBound.y * 1);
    }

    IEnumerator OneTime()
    {
        while (true)
        {
            respawnTime = Random.Range(20f, 30f);
            yield return new WaitForSeconds(respawnTime);
            spawnChest();
         }

    }
}
