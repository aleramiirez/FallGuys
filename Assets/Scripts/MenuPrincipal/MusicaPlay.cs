using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaPlay : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("musica").GetComponent<Musica>().PlayMusic();
    }
}
