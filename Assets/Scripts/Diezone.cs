using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diezone : MonoBehaviour
{
    public Movimentacao die;

    private Image GameOver, tela, BotaoRepetir, BotaoFases, BotaoMenus;

    private Button Repete2, Fases2, Menus2;

    private void Update()
    {
       
    

        if (die.morte == true)
        {




            tela = GameObject.Find("FundoFade").GetComponent<Image>();
            GameOver = GameObject.Find("MorteMural").GetComponent<Image>();

            BotaoRepetir = GameObject.Find("Repete").GetComponent<Image>();
            BotaoFases = GameObject.Find("Fases").GetComponent<Image>();
            BotaoMenus = GameObject.Find("Menus").GetComponent<Image>();

            Repete2 = GameObject.Find("Repete").GetComponent<Button>();
            Fases2 = GameObject.Find("Fases").GetComponent<Button>();
            Menus2 = GameObject.Find("Menus").GetComponent<Button>();

            GameObject.Find("Gauchito").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            Destroy(GameObject.Find("Gauchito"));
            GameOver.enabled = true;
            tela.enabled = true;
            Repete2.enabled = true;
            Fases2.enabled = true;
            Menus2.enabled = true;
            BotaoFases.enabled = true;
            BotaoMenus.enabled = true;
            BotaoRepetir.enabled = true;
           

        }
    }
}

