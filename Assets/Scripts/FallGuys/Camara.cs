using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject jugador;
    public Personaje personaje;
    Vector3 distancia;
    float alturaInicial;
    public float suavidad = 10f;

    void Start()
    {
        distancia = transform.position - jugador.transform.position;
        alturaInicial = transform.position.y;
    }

    void LateUpdate()
    {
        Vector3 targetPosition;
        if (personaje.Suelo())
        {
            targetPosition = new Vector3(
                jugador.transform.position.x + distancia.x,
                jugador.transform.position.y + distancia.y,
                jugador.transform.position.z + distancia.z
            );
            alturaInicial = transform.position.y;
        } else
        {
            targetPosition = new Vector3(
                jugador.transform.position.x + distancia.x,
                alturaInicial, // Mantén la altura inicial de la cámara
                jugador.transform.position.z + distancia.z);
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, suavidad * Time.deltaTime);
    }
}
