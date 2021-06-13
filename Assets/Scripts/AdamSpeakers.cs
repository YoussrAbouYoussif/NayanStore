using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdamSpeakers : MonoBehaviour
{
    Animator anim;
    float waitingTime = 1f;
    float timer = 0f;
    float yRotation = -192f;
    int count = 0;

    public AudioSource[] sounds;
    public AudioSource footstepsSound;
    public AudioSource danceMusic;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        sounds = GetComponents<AudioSource>();
        footstepsSound = sounds[1];
        danceMusic = sounds[0];
        footstepsSound.Play();
    }

    void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z>-35f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.02f);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isTurning", true);
            timer += Time.deltaTime;
            if (timer > waitingTime && !anim.GetBool("isDancing"))
            {
                footstepsSound.Stop();
                anim.SetBool("isTurning", false);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
                anim.SetBool("isIdle", true);
            }
            else if(timer < waitingTime)
            {
                anim.SetBool("isTurning", true);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
                yRotation += 1.15f;
            }
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(anim.GetBool("isIdle"))
            {
                anim.SetBool("isTurning", false);
                anim.SetBool("isIdle", false);
                anim.SetBool("isDancing", true);
                if (count == 0)
                {
                    danceMusic.Play();
                    count++;
                }
                else
                {
                    danceMusic.UnPause();
                }
            }
            else if(anim.GetBool("isDancing"))
            {
                anim.SetBool("isTurning", false);
                anim.SetBool("isDancing", false);
                anim.SetBool("isIdle", true);
                danceMusic.Pause();
            }
            
        }
    }
    public void switchSinging()
    {
        SceneManager.LoadScene("Singing");
    }
}
