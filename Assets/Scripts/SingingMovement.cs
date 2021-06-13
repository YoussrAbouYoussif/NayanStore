using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SingingMovement : MonoBehaviour
{

    // Start is called before the first frame update
    Animator anim;
    bool isPressed = false;

    AudioSource sound;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.GetComponent<Animator>().enabled = false;
   
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool s = Input.GetKeyDown("p");
        if (s == true && isPressed == false)
        {

          
            anim.GetComponent<Animator>().enabled = true;
            isPressed = true;
            sound.Play();
        }
        else if (s == true && isPressed == true)
        {

           
            isPressed = false;
            anim.GetComponent<Animator>().enabled = false;
            sound.Stop();
            sound.ignoreListenerVolume = true;
        }
    }
    public void DanceButton()
    {
        SceneManager.LoadScene("Dancing");
    }
}


