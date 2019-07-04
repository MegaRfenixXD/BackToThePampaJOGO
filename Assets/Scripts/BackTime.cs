using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTime : MonoBehaviour
{
   

    private TrailRenderer Rastro;

    private List<Vector3> positions;

    public int frameCount = 300;

    private bool recording = true;
    private int index = 0;
    private Rigidbody2D rb2d;

    void Start()
    {
        Rastro = GetComponent<TrailRenderer>();
        positions = new List<Vector3>();
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (recording)
        {
            index = 0;
            positions.Add(transform.position);
            if(positions.Count > frameCount)
            {
                positions.RemoveAt(0);
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Rastro.enabled = true;
            if(index < positions.Count)
            {
                recording = false;

                Time.timeScale = 0;
                transform.position = positions[positions.Count - 1 - index];
                index++;
            }

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Rastro.enabled = false;
            positions.Clear();
            recording = true;
            Time.timeScale = 1;
            rb2d.velocity = Vector2.zero;
            rb2d.angularVelocity = 0;
        }
    }
}
