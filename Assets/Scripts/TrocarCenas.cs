using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCenas : MonoBehaviour
{

    private string Nome;


    private void Start()
    {
        Nome = SceneManager.GetActiveScene().name;
    }

    public void Cena(string chave)
    {
        switch (chave)
        {

            case "Jogar":
                SceneManager.LoadScene("level1");
                break;

           case "Repetir":
                SceneManager.LoadScene(Nome);
                break;

            case "Sair":
                Application.Quit();
                break;

            case "Menu":
                SceneManager.LoadScene("Telainicio");
                break;

            case "Tela":
                SceneManager.LoadScene("TelaDeSelecao");
                break;

            case "Avançar2":
                SceneManager.LoadScene("level2");
                break;

            case "Avançar3":
                SceneManager.LoadScene("level3");
                break;

        }
    }
}
