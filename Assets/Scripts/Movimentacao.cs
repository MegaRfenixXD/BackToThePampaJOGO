using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    private float velo = 1f;
    public Animator animator, animator2, explosion, danoAnimator;

    public bool ativa;

    public bool morte = false;

    public MovimentacaoInimigo DanoInimigo;

    private GameObject pacotinho;

    public int VidaJogador = 3;

    [SerializeField]
    public float velocidadeAndar = 6;

    [SerializeField]
    public float intensidadePulo;

    [SerializeField]
    private Transform LinhaInicio, LinhaFim, l, r;

    private ControladorDeTempo control;

    private TrailRenderer rastros;

    public bool Explosao;

    public int contagem = 0;








    public Rigidbody2D velocidade;
    private RaycastHit2D hit;


    void Start()
    {

        rastros = GetComponent<TrailRenderer>();
        ativa = false;
        pacotinho = GameObject.FindGameObjectWithTag("mate");



        velocidade = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pacotinho = GameObject.FindGameObjectWithTag("mate");
        Morrer();
        Andar();
        pular();
        destroyEnemy();
        destroyy();


        animator.SetFloat("velocidadeAnim", Mathf.Abs(velocidade.velocity.x));
        animator2.SetFloat("puloAnim", Mathf.Abs(velocidade.velocity.y));

        
        RASTRO();



    }

    void Andar()
    {
        velocidade.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidadeAndar, velocidade.velocity.y);


    }

    void pular()
    {
        hit = Physics2D.Linecast(LinhaInicio.position, LinhaFim.position);
        Debug.DrawLine(LinhaInicio.position, LinhaFim.position, Color.red);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag == "piso")
            {

                if (Input.GetKey(KeyCode.Space))
                {
                    velocidade.velocity = new Vector2(velocidade.velocity.x, intensidadePulo);

                }
            }
        }
    }

    void destroyy()
    {
        hit = Physics2D.Linecast(l.position, r.position);
        Debug.DrawLine(l.position, r.position, Color.red);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag == "Erva")
            {

                ativa = true;

                Destroy(GameObject.FindGameObjectWithTag("Erva"));

            }
            if (hit.collider.gameObject.tag == "Moedas")
            {

                contagem++;
                Destroy(GameObject.FindGameObjectWithTag("Moedas"));
            }

            if (hit.collider.gameObject.tag == "Moedas2")
            {

                contagem++;
                Destroy(GameObject.FindGameObjectWithTag("Moedas2"));
            }

            if (hit.collider.gameObject.tag == "Moedas3")
            {

                contagem++;
                Destroy(GameObject.FindGameObjectWithTag("Moedas3"));
            }
        }
    }
    void destroyEnemy()
    {
        hit = Physics2D.Linecast(LinhaInicio.position, LinhaFim.position);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag == "Cruzeira1")
            {


                velocidade.velocity = new Vector2(velocidade.velocity.x, intensidadePulo);
                Destroy(GameObject.FindGameObjectWithTag("Cruzeira1"));
               // Explosao = true;

            }

            if (hit.collider.gameObject.tag == "Tatuzito1")
            {


                velocidade.velocity = new Vector2(velocidade.velocity.x, intensidadePulo);
                Destroy(GameObject.FindGameObjectWithTag("Tatuzito1"));
                //Explosao = true;

            }

            if (hit.collider.gameObject.tag == "Tatuzito2")
            {


                velocidade.velocity = new Vector2(velocidade.velocity.x, intensidadePulo);
                Destroy(GameObject.FindGameObjectWithTag("Tatuzito2"));
                //Explosao = true;

            }
        }


    }

    public void Pulinho()
    {
        velocidade.velocity = new Vector2(velocidadeAndar = -2, intensidadePulo = 0);
    }





    void RASTRO()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rastros.enabled = true;
        }
        else
        {
            rastros.enabled = false;
        }
    }

    void Morrer()
    {
        hit = Physics2D.Linecast(LinhaInicio.position, LinhaFim.position);
        if (hit.collider != null)
        {

            if (hit.collider.gameObject.tag == "Morte")
            {
                morte = true;
                Debug.Log("MORREU");


            }


        }



    }
}
