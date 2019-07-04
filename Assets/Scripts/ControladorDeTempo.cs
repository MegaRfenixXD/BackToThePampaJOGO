using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeTempo : MonoBehaviour
{

    public Gravador[] objetosAfetados;
    private int voltas=0;
    private float velocidade= 1.0f;
    private static bool gravando;
    public bool rastro;
    private Movimentacao veloci;

    public static bool Gravando
    {
        get
        {
            return gravando;
        }

        set
        {
            gravando = value;
        }
    }

    void Start()
    {
        veloci = GameObject.Find("Gauchito").GetComponent<Movimentacao>();
        objetosAfetados = GameObject.FindObjectsOfType<Gravador>();
    }

    
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //voltar no tempo

            StartCoroutine(voltando());
            gravando = false;
            rastro = true;
            veloci.velocidadeAndar = 0.0f;
        
        }
        else
        {
            
            voltas = 0;
            gravando = true;
            StopCoroutine(voltando());
            rastro = false;
            veloci.velocidadeAndar = 3f;
        }
    }

    IEnumerator voltando()
    {
        while (true)
        {
            if (gravando)
            {
                break;
            }
            voltas += 1;
            foreach (Gravador gravadorDoObjeto in objetosAfetados)
            {
                gravadorDoObjeto.voltarPosicao(voltas);
            }
            yield return new WaitForSeconds(velocidade);
        }
    }
}
