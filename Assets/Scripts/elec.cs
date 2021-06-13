using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elec : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    bool isPressed = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        bool e = Input.GetKeyDown("e");
        if (e == true && isPressed == false)
        {
            //guitar.transform.Rotate(-21.12f, -414.6f, 240.12f);
            //guitar.transform.Translate(-0.99f, 0.48f, -0.74f);
            //anim.SetBool("electrical", true);
            //sound.Play();
            anim.GetComponent<Animator>().enabled = true;
            isPressed = true;
        }
        else if (e == true && isPressed == true)
        {
            //guitar.transform.Rotate(21.12f, 414.6f, -240.12f);
            //guitar.transform.Translate(0.99f, -0.48f, 0.074f);
            //anim.SetBool("electrical", false);
            anim.GetComponent<Animator>().enabled = false;
            isPressed = false;
            //sound.Stop();
            //sound.ignoreListenerVolume = true;
        }
    }
}
