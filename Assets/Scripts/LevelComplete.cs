using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    [SerializeField]
    private Transform Hr, Hl;

    private RaycastHit2D hit;

    public colisao Colisao;

    public Text Congratulacoes, Text1, Text2;


    public Image botao1, botao2, botao3,tela;

    public SpriteRenderer Moedas, Mural, Fade,Moedas2;

    public Rigidbody2D hero;

    public Movimentacao moedas;

   public Button avan, repe, me;

    public bool concluido = false;
   

    


    private void Start()
    {
        tela = GameObject.Find("FundoFade").GetComponent<Image>();
        hero = GameObject.Find("Gauchito").GetComponent<Rigidbody2D>();
        botao1 = GameObject.Find("Avancar").GetComponent<Image>();
        botao2 = GameObject.Find("RepetirFase").GetComponent<Image>();
        botao3 = GameObject.Find("Menu").GetComponent<Image>();

        avan = GameObject.Find("Avancar").GetComponent<Button>();
        repe = GameObject.Find("RepetirFase").GetComponent<Button>();
        me = GameObject.Find("Menu").GetComponent<Button>();

        Moedas = GameObject.Find("Moedas").GetComponent<SpriteRenderer>();
       
        Mural = GameObject.Find("MenuFinal").GetComponent<SpriteRenderer>();

        Text1 = GameObject.Find("Desempenho").GetComponent<Text>();
        Text2 = GameObject.Find("DesempenhoText").GetComponent<Text>();








        Colisao = GameObject.Find("pacotinho").GetComponent<colisao>();


    }
    private void colidircomsave()
    {
        if (Colisao.lvlpronto)
        {



            hit = Physics2D.Linecast(Hl.position, Hr.position);
            Debug.DrawLine(Hl.position, Hr.position, Color.green);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "NEXT")
                {
                    concluido = true;
                    GameObject.Find("Gauchito").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                    Congratulacoes.text = "PARABÉNS";
                    Moedas.enabled = true;
                    Mural.enabled = true;


                   
                    botao1.enabled = true;
                    botao2.enabled = true;
                    botao3.enabled = true;
                    avan.enabled = true;
                    repe.enabled = true;
                    me.enabled = true;

                    Text1.enabled = true;
                    Text2.enabled = true;
                

                    if(moedas.contagem == 0)
                    {
                        
                    }
                    
                    hero.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY; 
                    

                    


                }
            }
        }
    }

    void Update()
    {
        colidircomsave();
    }
}
