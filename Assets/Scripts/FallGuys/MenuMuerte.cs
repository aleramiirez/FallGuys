using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMuerte : MonoBehaviour
{
    public GameObject objetoMenuMuerte;
    public Personaje personaje;
    public bool pausa = false;


    void Update()
    {
        if (personaje.countVidas == 0)
        {

            objetoMenuMuerte.SetActive(true);
            pausa = true;
            Time.timeScale = 0f;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
