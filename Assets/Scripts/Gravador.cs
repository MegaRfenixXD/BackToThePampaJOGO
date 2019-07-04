using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gravador : MonoBehaviour
{
    [SerializeField] private bool afetado = true;

    private List<Vector3> posicoes;


    void Start()
    {
        posicoes = new List<Vector3>();
    
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (afetado && ControladorDeTempo.Gravando)
        {


            posicoes.Add(transform.position);
        }
    }


    public void voltarPosicao (int voltas)
    {
        //voltar o vetor a posicao 
        try
        {
            transform.position = posicoes[posicoes.Count - 1 - voltas];
            int indiceInicial = posicoes.Count - 1 - voltas;
            posicoes.RemoveRange(indiceInicial, posicoes.Count - indiceInicial);
            print("voltou no tempo");
        }
        catch
        {
            print("não pode mais voltar no tempo");
        }
    }
}
