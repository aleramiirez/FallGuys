using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    public GameObject prefabObjeto; // Asigna el prefab desde el Inspector
    public float tiempoEspera = 5f;

    void Start()
    {
        StartCoroutine(GenerarGlovo());
    }


    private IEnumerator GenerarGlovo()
    {
        while (true)
        {
            // Instancia un nuevo objeto y obtiene una referencia a él
            GameObject nuevoObjeto = Instantiate(prefabObjeto, transform.position, Quaternion.identity);

            // Ajusta la rotación del nuevo objeto para que aparezca correctamente
            nuevoObjeto.transform.rotation = Quaternion.Euler(0f, -90f, 90f);

            // Espera 5 segundos antes de destruir el objeto actual
            yield return new WaitForSeconds(tiempoEspera);

            // Destruye el objeto actual
            Destroy(nuevoObjeto);
        }
    }
}
