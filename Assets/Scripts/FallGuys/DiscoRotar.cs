using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoRotar : MonoBehaviour
{

    public float velocidadRotacion = 5f;
    public Quaternion rotacionPersonaje;

    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadRotacion * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Almacenar la rotación actual del personaje
            rotacionPersonaje = collision.transform.rotation;

            // Hacer que el personaje sea hijo del disco
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Dejar de hacer que el personaje sea hijo del disco
            collision.transform.parent = null;

            // Restablecer la rotación original del personaje
            collision.transform.rotation = rotacionPersonaje;
        }
    }
}
