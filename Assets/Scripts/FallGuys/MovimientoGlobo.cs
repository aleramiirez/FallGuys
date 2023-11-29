using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoGlobo : MonoBehaviour
{

    public float velocidad = 4f;

    void Update()
    {
        transform.Translate(-Vector3.forward * velocidad * Time.deltaTime);

    }
}
