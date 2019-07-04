using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    [SerializeField]
    private float maximoX;

    [SerializeField]
    private float minimoX;

    [SerializeField]
    private float minimoY;

    [SerializeField]
    private float maximoY;

    public Transform Hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(Hero.position.x, minimoX, maximoX), Mathf.Clamp(Hero.position.y, minimoY, maximoY),transform.position.z);
    }
}
