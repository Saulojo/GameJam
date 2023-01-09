using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource musicadefundo;
    public AudioClip musica;
    // Start is called before the first frame update
    void Start()
    {
        musicadefundo.clip = musica;
        musicadefundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
