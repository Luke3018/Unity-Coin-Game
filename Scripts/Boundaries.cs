using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objWidth;
    private float objHeight;

    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -90f, 90f), Mathf.Clamp(transform.position.y, -25.0f, 25.0f), transform.position.z);
    }
}
