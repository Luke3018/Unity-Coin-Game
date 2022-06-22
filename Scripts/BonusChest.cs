using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusChest : MonoBehaviour
{

    public float speed = 5f;
    private Vector2 screenBounds;
    private Rigidbody2D rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        speed += 60;
    }

    void Update()
    {
        if (transform.position.y < 10)
        {
            Destroy(this.gameObject);
        }
    }


}
