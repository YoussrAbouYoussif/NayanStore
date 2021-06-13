using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    bool isPressed = false;
    public GameObject guitar;
    AudioSource sound;
    void Start()
    {
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool s = Input.GetKeyDown("p");
        if (s == true && isPressed == false)
        {
            guitar.transform.Translate(-0.3f, 0, -0.09f);
            anim.SetBool("guitarPlaying", true);
            isPressed = true;
            sound.Play();
        }
        else if (s == true && isPressed == true)
        {
            guitar.transform.Translate(0.3f, 0, 0.09f);
            anim.SetBool("guitarPlaying", false);
            isPressed = false;
            sound.Stop();
            sound.ignoreListenerVolume = true;
        }
    }
        public void Switch()
        {
            SceneManager.LoadScene("ElectricGuitarScene");
        }
    
}
