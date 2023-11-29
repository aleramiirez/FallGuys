using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    public float velocidadRotacion = 80.0f;

    void Update()
    {
        // Desvincular el objeto hijo
        Transform hijo = transform.GetChild(0); // Puedes ajustar el índice según la jerarquía de tu objeto
        hijo.parent = null;

        // Rotar solo el objeto actual alrededor del eje Y
        transform.Rotate(-Vector3.forward, velocidadRotacion * Time.deltaTime);

        // Volver a vincular el objeto hijo al objeto padre
        hijo.parent = transform;
    }
}
