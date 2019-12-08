using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarSpriteInimigo2 : MonoBehaviour
{ 
private SpriteRenderer mySpriteRenderer;

public MovimentacaoInimigo2 inimigomove2;
// Start is called before the first frame update
void Start()
{
    inimigomove2 = GameObject.Find("Tatuzito2").GetComponent<MovimentacaoInimigo2>();
}

// This function is called just one time by Unity the moment the component loads
private void Awake()
{
    // get a reference to the SpriteRenderer component on this gameObject
    mySpriteRenderer = GetComponent<SpriteRenderer>();
}

// This function is called by Unity every frame the component is enabled
private void Update()
{
    // if the A key was pressed this frame
    if (inimigomove2.girarinimigo == true)
    {
        // if the variable isn't empty (we have a reference to our SpriteRenderer
        if (mySpriteRenderer != null)
        {
            // flip the sprite
            mySpriteRenderer.flipX = true;
        }
    }
    if (inimigomove2.girarinimigo == false)

    {
        // if the variable isn't empty (we have a reference to our SpriteRenderer
        if (mySpriteRenderer != null)
        {
            // flip the sprite
            mySpriteRenderer.flipX = false;
        }
    }
}
}
