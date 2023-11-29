using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Personaje : MonoBehaviour
{
    Rigidbody rb;
    Vector3 posicionInicial;
    Vector3 checkPoint = new Vector3(0.351f, 1.433f, -24.543f);
    Vector3 checkPoint2 = new Vector3(25.162f, 0.18f, 74.46f);
    public TextMeshProUGUI vidas;
    public int countVidas = 3;
    public GameObject Corazon1;
    public GameObject Corazon2;
    public GameObject Corazon3;
    public Animator animator;

    public float velocidadMovimiento = 5.0f; // Velocidad de movimiento del personaje
    public float fuerzaSalto = 8.0f; // Fuerza aplicada al saltar
    private bool enElSuelo; // Variable para rastrear si el personaje está en el suelo
    public GameObject GrupoVictoria;
    public float fuerzaEmpuje = 10.0f;
    public AudioClip jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
            // Obtener la entrada del teclado
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            // Calcular el movimiento en base a la entrada del teclado
            Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;

            // Aplicar el movimiento al personaje
            transform.Translate(movimiento);

            // Verificar si el personaje está en el suelo (puedes personalizar esta verificación según tu configuración)
            enElSuelo = Physics.Raycast(transform.position, Vector3.down, 0.1f);

            // Permitir el salto solo si el personaje está en el suelo y se presiona la barra espaciadora
            if (enElSuelo && Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, fuerzaSalto, 0);
                AudioSource.PlayClipAtPoint(jump, transform.position);

            }

        bool andando = (movimiento != Vector3.zero);
            animator.SetBool("Andar", andando);

            bool saltando = Input.GetKeyDown(KeyCode.Space);
            animator.SetBool("Saltar",saltando);
    }

    public bool Suelo()
    {
        bool suelo = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        if (suelo)
        {
            return true;
        } else { return false; }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("CheckPoint1"))
        {
            posicionInicial = checkPoint;
        } 
        if (other.gameObject.CompareTag("CheckPoint2"))
        {
            posicionInicial = checkPoint2;
        }
         if (other.gameObject.CompareTag("Finish"))
        {
            GrupoVictoria.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        if (other.gameObject.CompareTag("Vida"))
        {
            countVidas++;
            if (countVidas == 3)
            {
                Corazon3.SetActive(true); 
            }
            if (countVidas == 2)
            {
                Corazon2.SetActive(true); 
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("respawn"))
        {
            transform.position = posicionInicial;
            countVidas--;
            if (countVidas == 2)
            {
                Corazon3.SetActive(false); // Desactiva el tercer corazón
            }
            else if (countVidas == 1)
            {
                Corazon2.SetActive(false); // Desactiva el segundo corazón
            }
            else if (countVidas == 0)
            {
                Corazon1.SetActive(false); // Desactiva el primer corazón
            }
        }
    }
}
