using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentacaoInimigo : MonoBehaviour
{

    [SerializeField]
    private Transform limiteInicio, limiteFim;

    [SerializeField]
    private float velocidadebase;

    [SerializeField]
    private float velocidade;

    public Rigidbody2D fisica;

    public bool girarinimigo;

    private Animator animator;

    public Movimentacao destroiinimigo;

    public int VidaJogador = 3;

    public bool TomouDano;

    private Image GameOver,tela,BotaoRepetir,BotaoFases,BotaoMenus;

    private Button Repete2, Fases2, Menus2;





    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();
        destroiinimigo = GameObject.Find("Gauchito").GetComponent<Movimentacao>();

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Andar();
       // animator.SetBool("explosion", destroiinimigo.explosion);
    }
    void Andar()
    {
        fisica.velocity = new Vector2(velocidade, fisica.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.tag == "Player")
        {
            Debug.Log("Vidas:" + VidaJogador);
            
            
            VidaJogador--;

            if(VidaJogador < 1)
            {
                tela = GameObject.Find("FundoFade").GetComponent<Image>();
                GameOver =  GameObject.Find("MorteMural").GetComponent<Image>();

                BotaoRepetir = GameObject.Find("Repete").GetComponent<Image>();
                BotaoFases= GameObject.Find("Fases").GetComponent<Image>();
                BotaoMenus = GameObject.Find("Menus").GetComponent<Image>();

                Repete2= GameObject.Find("Repete").GetComponent<Button>();
                Fases2 = GameObject.Find("Fases").GetComponent<Button>();
                Menus2 = GameObject.Find("Menus").GetComponent<Button>();



                Destroy(GameObject.Find("Gauchito"));
                GameOver.enabled = true;
                tela.enabled = true;
                BotaoFases.enabled = true;
                BotaoMenus.enabled = true;
                BotaoRepetir.enabled = true;
                Repete2.enabled = true;
                Fases2.enabled = true;
                Menus2.enabled = true;
            }










        }
        if (outro.gameObject.tag == "LimiteDireita")
        {
            velocidade = -velocidade;
            girarinimigo = true;
        }
        if (outro.gameObject.tag == "LimiteEsquerda")
        {
            velocidade = velocidadebase;
            girarinimigo = false;
        }
    }

}
