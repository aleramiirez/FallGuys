using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaStop : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("musica").GetComponent<Musica>().StopMusic();
    }

   
}
