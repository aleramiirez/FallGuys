using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 120f;

    public TextMeshProUGUI textoTimer;
    private int minutos, segundos;

    public GameObject objetoMenuMuerte;
    public bool pausa = false;
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            minutos = (int)(timer / 60f);
            segundos = (int)(timer - minutos * 60f);

            textoTimer.text = "Tiempo: " + string.Format("{0:00}:{1:00}", minutos, segundos);
        }
        else
        {
            objetoMenuMuerte.SetActive(true);
            pausa = true;
            Time.timeScale = 0f;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
