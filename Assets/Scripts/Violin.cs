using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Violin : MonoBehaviour
{
    Animator anim;
    AudioSource audioSource;
    public AudioClip clip; 
    bool playViolin = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("playViolin", false);
        anim.SetBool("standUp", false);
        audioSource = GetComponent<AudioSource>();

    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p")){
            anim.SetBool("playViolin", !anim.GetBool("playViolin"));
        }
        if(Input.GetKeyDown("s")){
            anim.SetBool("standUp", !anim.GetBool("standUp"));
        }
        if(anim.GetBool("playViolin") && anim.GetBool("standUp")){
            
            if (!audioSource.isPlaying){
            audioSource.Play();
            }

            
        }
        else{
             audioSource.Stop();

        }
        
    }
}
