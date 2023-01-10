using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoCena : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int cenaIndice;
    Scene scene;
    public int indice;
    public AudioSource SomTransicao;
    public AudioClip transiction_sound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            scene = SceneManager.GetActiveScene();
            indice = scene.buildIndex;
            SomTransicao.clip = transiction_sound;
            SomTransicao.Play();
            IniciaTransicao(indice);

        }

    }

    //Esse m�todo � chamado em qualquer evento que troque a cena do jogo
    public void IniciaTransicao(int _cenaIndice)
    {
        cenaIndice = _cenaIndice;
        animator.SetTrigger("Inicia");
    }

    //Esse m�todo � chamado no final da anima��o
    public void TrocaCena()
    {
        SceneManager.LoadScene(cenaIndice+1);
    }
}