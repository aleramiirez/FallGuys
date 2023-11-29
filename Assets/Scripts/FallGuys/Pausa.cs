using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject objetoMenuPausa;
    public bool pausa = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausa)
            {
                objetoMenuPausa.SetActive(true);
                pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

            } else if (pausa)
            {
                reanudar();
            }
        }
    }

    public void reanudar()
    {
        objetoMenuPausa.SetActive(false);
        pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
