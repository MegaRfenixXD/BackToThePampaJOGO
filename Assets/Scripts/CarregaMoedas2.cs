using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregaMoedas2 : MonoBehaviour
{
    public Moedas2 fabs;
    public Movimentacao moedas;



    private int vari2;



    public Sprite moedas0, moedas1, moedas2, moedas3, Gravar;

    void Start()
    {
        vari2 = PlayerPrefs.GetInt("level2");



        Gravar = GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = moedas0;
    }

    // Update is called once per frame
    void Update()
    {








        if (vari2 == 0)
        {
            Gravar = GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = moedas0;



        }

        if (vari2 == 1)
        {
            Gravar = GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = moedas1;


        }

        if (vari2 == 2)
        {
            Gravar = GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = moedas2;


        }

        if (vari2 == 3)
        {
            Gravar = GameObject.Find("level2").GetComponent<SpriteRenderer>().sprite = moedas3;


        }
    }
}
