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

    public Text Congratulacoes, Text1, Text2, Text3,Text4,Text5;


    public Image botao1, botao2, botao3;

    public SpriteRenderer Moedas, Mural, Fade;

    public Rigidbody2D hero;

    public Movimentacao moedas;

   

    


    private void Start()
    {

        hero = GameObject.Find("Gauchito").GetComponent<Rigidbody2D>();

       
        Moedas = GameObject.Find("Moedas").GetComponent<SpriteRenderer>();
        Mural = GameObject.Find("MenuFinal").GetComponent<SpriteRenderer>();

        botao1 = GameObject.Find("Avancar").GetComponent<Image>();
        botao2 = GameObject.Find("RepetirFase").GetComponent<Image>();
        botao3 = GameObject.Find("Menu").GetComponent<Image>();

        Text1 = GameObject.Find("ProximaFase").GetComponent<Text>();
        Text4 = GameObject.Find("Desempenho").GetComponent<Text>();
        Text5 = GameObject.Find("DesempenhoText").GetComponent<Text>();

        Text2 = GameObject.Find("Repetir").GetComponent<Text>();
        Text3 = GameObject.Find("MenuFase").GetComponent<Text>();





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

                    Congratulacoes.text = "PARABÉNS";
                    Moedas.enabled = true;
                    Mural.enabled = true;

                    Text4.enabled = true;
                    Text5.enabled = true;

                    botao1.enabled = true;
                    botao2.enabled = true;
                    botao3.enabled = true;

                    Text1.enabled = true;
                    Text2.enabled = true;
                    Text3.enabled = true;

                    if(moedas.contagem == 0)
                    {
                        
                    }
                    
                    hero.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY; 
                    

                    Destroy(GameObject.FindGameObjectWithTag("NEXT"));


                }
            }
        }
    }

    void Update()
    {
        colidircomsave();
    }
}
