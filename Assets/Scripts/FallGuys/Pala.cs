using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    public float velocidadRotacion = 10.0f;

    private void Start()
    {
        StartCoroutine(RotacionPala());
    }

    void Update()
    {
        transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime);
    }

    IEnumerator RotacionPala()
    {
        while (true)
        {
            float tiempo = Random.Range(3f, 10f);

            yield return new WaitForSeconds(tiempo);

            velocidadRotacion *= -1;
        }
    }
}
