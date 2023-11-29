using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Fall guys");
    }

    public void EscenaOpciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
