using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            TomouDano = true;
            SoundManager.Playsound("Dano");
            destroiinimigo.Pulinho();
            VidaJogador--;










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
