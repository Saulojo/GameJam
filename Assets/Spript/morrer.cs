using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morrer : MonoBehaviour
{
    //private bool Respawnarplayer;
    private GameObject spawn;
    private Rigidbody2D rig;

    public AudioSource Diesound;
    public AudioClip dying_sound;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawn");
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colision) {

        if (colision.CompareTag("espinhos") == true){
            Diesound.clip = dying_sound;
            Diesound.Play();
            rig.transform.position = new Vector2(spawn.transform.position.x,spawn.transform.position.y);

        }
    }

}
