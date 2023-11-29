using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEscalon : MonoBehaviour
{
    public float velocidadMovimiento = 1.0f; // Velocidad de movimiento en unidades por segundo
    public float distanciaMovimiento = 2.0f; // Distancia total que recorrer0 el escal0n

    private Vector3 posicionInicial;

    void Start()
    {
        // Almacenar la posicion inicial del escalon
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Calcular el desplazamiento en base a la velocidad constante
        float desplazamiento = Mathf.PingPong(Time.time * velocidadMovimiento, distanciaMovimiento * 2) - distanciaMovimiento;

        // Calcular la nueva posicion del escal0n
        float nuevaPosicionY = posicionInicial.y + desplazamiento;

        // Actualizar la posicion del escal0n
        transform.position = new Vector3(transform.position.x, nuevaPosicionY, transform.position.z);
    }

}
