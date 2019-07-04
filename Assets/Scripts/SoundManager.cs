using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{

    public static AudioClip Dano;
    static AudioSource audiosrc;

    void Start()
    {
        Dano = Resources.Load<AudioClip>("EfeitosSonoros/Dano");

        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "Dano":
                audiosrc.PlayOneShot(Dano);
                break;
        }



    }


    public void Cenas(string cena)
    {
        switch (cena)
        {

            case "Jogar":
                SceneManager.LoadScene("level1");
                break;


            case "Quit":
                Application.Quit();
                break;







        }
    }
}
