using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{
    public float velocidadRotacion = 200.0f; // Velocidad de rotaci�n en grados por segundo

    void Update()
    {
        // Rotar la h�lice constantemente sobre su propio eje
        transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime, Space.Self);
    }

}
