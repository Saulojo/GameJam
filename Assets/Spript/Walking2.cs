using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking2 : MonoBehaviour
{

    public Rigidbody2D corpoPersonagem;
    public Transform posicaoDoPe;
    public int nPulos = 1;

    public LayerMask chao;

    public float velocidade;
    public float forcaPulo;

    private float direcao;
    private bool estaNoChao;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        estaNoChao = Physics2D.OverlapCircle(posicaoDoPe.position, 0.3f, chao);

        direcao = Input.GetAxisRaw("Horizontal");

        corpoPersonagem.velocity = new Vector2(direcao * velocidade, corpoPersonagem.velocity.y);

        

        if(Input.GetKeyDown(KeyCode.W) && estaNoChao)
        {
            corpoPersonagem.velocity = Vector2.up * forcaPulo;
        }

        CheckInput();
    }

    void CheckInput()
    {
        if(estaNoChao)
        {
            nPulos = 1;
        }
        if(Input.GetKeyDown(KeyCode.W) && nPulos > 0)
        {
            Jump();
        }
    }

    void Jump()
    {
        nPulos = nPulos-1;
        corpoPersonagem.velocity = Vector2.up * forcaPulo;
    }
}
