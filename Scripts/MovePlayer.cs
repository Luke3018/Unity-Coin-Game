using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirx;
    public float movespeed = 200.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirx = CrossPlatformInputManager.GetAxis("Horizontal") * movespeed;
        rb.velocity = new Vector2(dirx * 10, 0f);
    }
}
