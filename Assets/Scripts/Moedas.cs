using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{


    private string Nome;

    public Text moedinhas,desempenho;

    public Sprite moedas0, moedas1, moedas2, moedas3, Gravar,Cena;


    public Movimentacao moedas;

    public int vari2;

    public LevelComplete lc;






    void Start()
    {
        lc = GameObject.Find("pacotinho").GetComponent<LevelComplete>();

        Nome = SceneManager.GetActiveScene().name;

        moedinhas = GameObject.Find("MoedinhasText").GetComponent<Text>();

        Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas0;

        Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas0;

        desempenho = GameObject.Find("DesempenhoText").GetComponent<Text>();



        vari2 = PlayerPrefs.GetInt("level1", moedas.contagem);





        if (vari2 == 0)
        {

            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas0;
            


        }

        if (vari2 == 1)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas1;


        }

        if (vari2 == 2)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas2;


        }

        if (vari2 == 3)
        {
            Gravar = GameObject.Find("Teste").GetComponent<SpriteRenderer>().sprite = moedas3;


        }


    }

    // Update is called once per frame
    void Update()
    {
        {
            moedinhas.text = "X" + moedas.contagem.ToString();




            if (lc.concluido == true) {

                if (moedas.contagem == 0)
                {

                    Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas0;
                    PlayerPrefs.SetInt("level1", moedas.contagem);
                    desempenho.text = "Ruim";


                }



            }

            if (moedas.contagem == 1)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas1;

                PlayerPrefs.SetInt("level1", moedas.contagem);
                desempenho.text = "Bom";

            }



            if (moedas.contagem == 2)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas2;
                PlayerPrefs.SetInt("level1", moedas.contagem);
                desempenho.text = "Otimo";



            }

            if (moedas.contagem == 3)
            {
                Cena = GameObject.Find("Moedas").GetComponent<SpriteRenderer>().sprite = moedas3;

                PlayerPrefs.SetInt("level1", moedas.contagem);
                desempenho.text = "Execelente";
            }

        }
    }














        }




