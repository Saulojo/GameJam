using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoCena : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int cenaIndice;
    Scene scene;
    public int indice;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scene = SceneManager.GetActiveScene();
            indice = scene.buildIndex;
            IniciaTransicao(indice);
        }

    }

    //Esse método é chamado em qualquer evento que troque a cena do jogo
    public void IniciaTransicao(int _cenaIndice)
    {
        cenaIndice = _cenaIndice;
        animator.SetTrigger("Inicia");
    }

    //Esse método é chamado no final da animação
    public void TrocaCena()
    {
        SceneManager.LoadScene(cenaIndice+1);
    }
}