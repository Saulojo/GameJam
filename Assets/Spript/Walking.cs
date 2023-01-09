using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public bool movimenta = false;
    float velocidade = 5.0f;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
    }

    void movimento()
    {


        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * velocidade * Time.deltaTime, Space.World);
            movimenta = true;

        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime, Space.World);
            movimenta = true;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidade * Time.deltaTime, Space.World);
            movimenta = true;
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime, Space.World);
            movimenta = true;
        }

        else
        {
            movimenta = false;
        }

    }
}
