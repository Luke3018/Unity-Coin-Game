using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour  
{

    public float speed = 15f;
    private Vector2 screenBounds;
    private Rigidbody2D rb;
    public Text score;
    public int increase = 0;
    public string Txt = "";

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        speed += 10;
    }

    void Update()
    {

        Txt = score.text;
        int.TryParse(Txt , out increase);

        speed += Time.deltaTime;
       
       if (transform.position.y < 10)
        {
            Destroy(this.gameObject);
        }
    }


}
