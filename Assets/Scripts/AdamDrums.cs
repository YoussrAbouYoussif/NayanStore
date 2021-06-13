using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamDrums : MonoBehaviour
{
    Animator anim;
    float waitingTime = 1f;
    float timer = 0f;
    float yRotation = -192f;
    bool doneFlag = false;

    public AudioSource[] sounds;
    public AudioSource footstepsSound;
    public AudioSource drumsMusic;
    public AudioSource chairPush;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        sounds = GetComponents<AudioSource>();
        footstepsSound = sounds[2];
        drumsMusic = sounds[1];
        chairPush = sounds[0];
        footstepsSound.Play();
    }

    void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z > -35f)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - 0.02f);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isTurning", true);
            timer += Time.deltaTime;
            if (timer > waitingTime && !doneFlag)
            {
                footstepsSound.Stop();
                anim.SetBool("isTurning", false);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
                anim.SetBool("isSittingDown", true);
                anim.SetBool("isSitting", true);
                chairPush.Play();
                doneFlag = true;
            }
            else if (timer < waitingTime)
            {
                anim.SetBool("isTurning", true);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
                yRotation += 2f;
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (anim.GetBool("isSitting"))
                {
                    anim.SetBool("isPlaying", true);
                    anim.SetBool("isSitting", false);
                    anim.SetBool("isSittingDown", false);
                    drumsMusic.Play();
                }
                else if (anim.GetBool("isPlaying"))
                {
                    anim.SetBool("isSitting", true);
                    anim.SetBool("isPlaying", false);
                    anim.SetBool("isSittingDown", false);
                    drumsMusic.Stop();
                }

            }
        }
    }
}
