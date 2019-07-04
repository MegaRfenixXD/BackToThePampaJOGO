using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{


    private string Nome;

    public Text moedinhas;

    public Sprite moedas0, moedas1, moedas2, moedas3, Gravar,Cena;


    public Movimentacao moedas;

    public int vari;






    void Start()
    {
        Nome = SceneManager.GetActiveScene().name;

        moedinhas = GameObject.Find("MoedinhasText").GetComponent<Text>();


        Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas0;

        Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas0;



        vari = PlayerPrefs.GetInt("level1", moedas.contagem);





        if (vari == 0)
        {

            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas0;


        }

        if (vari == 1)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas1;


        }

        if (vari == 2)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas2;


        }

        if (vari == 3)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas3;


        }


    }

    // Update is called once per frame
    void Update()
    {
        {
            moedinhas.text = "X" + moedas.contagem.ToString();

           

            


            if (moedas.contagem == 0)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas0;
                PlayerPrefs.SetInt("level1", moedas.contagem);

            }
                
               

            }

            if (moedas.contagem == 1)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas1;
                
               PlayerPrefs.SetInt("level1", moedas.contagem);
                }

            

            if (moedas.contagem == 2)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas2;
                PlayerPrefs.SetInt("level1", moedas.contagem);
                

            }

            if (moedas.contagem == 3)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas3;
               
                PlayerPrefs.SetInt("level1", moedas.contagem);

            }
          














        }
    }



