using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carril : MonoBehaviour
{
    public float width;
    public float speed;
    private float xCenter;


    void Start()
    {
        xCenter = transform.position.x;
    }

    void Update()
    {
        float newX = xCenter + Mathf.PingPong(Time.time * speed, width) - width / 2f;
        transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
    }
}

