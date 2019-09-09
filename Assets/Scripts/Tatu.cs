using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tatu : MonoBehaviour
{
   

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.tag == "piso")
        {
            Destroy(this.gameObject);
        }
    }
}
