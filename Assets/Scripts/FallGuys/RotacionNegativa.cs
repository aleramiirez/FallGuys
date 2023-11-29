using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionNegativa : MonoBehaviour
{
    public float velocidad = 160.0f;

    void Update()
    {
        transform.Rotate(-Vector3.up, velocidad * Time.deltaTime);
    }
}
