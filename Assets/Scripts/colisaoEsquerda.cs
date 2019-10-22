using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoEsquerda : MonoBehaviour
{
    private SpriteRenderer Sprite;
    private BoxCollider2D colisaao;
    public Movimentacao movimentacao;
    public LevelComplete lvlcompleto;
    private GameObject pacote;

    public bool lvlpronto = false;

    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        colisaao = GetComponent<BoxCollider2D>();
        movimentacao = GameObject.Find("Gauchito").GetComponent<Movimentacao>();

    }


    private void Update()
    {
        if (movimentacao.ativa)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                Debug.Log("oi");
                Sprite.enabled = true;
                colisaao.enabled = true;
                lvlpronto = true;

               
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                Debug.Log("oi");
                Sprite.enabled = false;
                colisaao.enabled = false;
                lvlpronto = false;

                
            }
        }
    }

}



