using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAutomatico : MonoBehaviour
{
    private Rigidbody2D hero;

    private int velocidadeAndar = 5, velocidadebase = 5;

    private SpriteRenderer heroi;


    
    void Start()
    {
        heroi = GetComponent<SpriteRenderer>();
        hero = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Andar();



        
    }


    void Andar()
    {
        hero.velocity = new Vector2(velocidadeAndar, hero.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        


            if (outro.gameObject.tag == "LimiteDireita")
            {
                velocidadeAndar = -velocidadeAndar;
                heroi.flipX = true;
            }
            if (outro.gameObject.tag == "LimiteEsquerda")
            {
                velocidadeAndar = velocidadebase;
                heroi.flipY = false;
            }



        
      



    }
}
