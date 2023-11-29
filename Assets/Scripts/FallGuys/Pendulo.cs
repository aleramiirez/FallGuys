using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    public float amplitud = 30.0f; // Ángulo máximo de oscilación
    public float velocidad = 1.0f; // Velocidad de oscilación
    public float fuerzaEmpuje = 5.0f; // Fuerza de empuje al colisionar

    void Update()
    {
        float angulo = amplitud * Mathf.Sin(velocidad * 2 * Time.time);
        transform.localRotation = Quaternion.Euler(0f, 0f, angulo);
    }
}
