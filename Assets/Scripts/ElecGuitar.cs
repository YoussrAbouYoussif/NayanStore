using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecGuitar : MonoBehaviour
{
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
        bool p = Input.GetKeyDown("p");
        if (p == true && isPressed == false)
        {
            anim.GetComponent<Animator>().enabled = true;
            isPressed = true;
            sound.Play();
        }
        else if (p == true && isPressed == true)
        {
            anim.GetComponent<Animator>().enabled = false;
            isPressed = false;
            sound.Stop();
            sound.ignoreListenerVolume = true;
        }
    }
}
