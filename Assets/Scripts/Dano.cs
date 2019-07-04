using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dano : MonoBehaviour
{
    public Sprite Vida0, Vida1, Vida2, Vida3;



    public MovimentacaoInimigo vida;






    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Vida3;




        vida = GameObject.Find("Cruzeira").GetComponent<MovimentacaoInimigo>();


    }

    // Update is called once per frame
    void Update()
    {
        if (vida.VidaJogador == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Vida2;

        }

        if (vida.VidaJogador == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Vida1;

        }

        if (vida.VidaJogador == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Vida0;

        }



    }

}

