using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionistMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    float time_in_seconds = 0.0f;
    int countSit = 0;
    int countMove = 0;
    bool isMoved = false;
    bool isSit = false;
    bool startRotating = false;
    int countRotating = 0;
    public  int testCount =150;
    void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        time_in_seconds += Time.deltaTime;
        if(((int)time_in_seconds) == 2 && (isMoved == false))
        {
            anim.SetBool("Move",true);
            isMoved = true;
        }
        if(isMoved)
        {
            countMove = countMove + 1;
            if(countMove == 49)
            {
                anim.SetBool("Move",false);
                startRotating = true;
                transform.Translate(0, 0, 32f);            
            }

        }

        if(startRotating){
            if(countRotating<105){
               transform.Rotate(0, -1.0f, 0);
               countRotating = countRotating +1;
            }else{ 
                startRotating = false;
                anim.SetBool("sitting",true);
                isSit = true;
                transform.position = new Vector3(-160.0f, 1.0f, -53f);
            }
        }
        if(isSit){
            countSit = countSit + 1;
            if(countSit == 150){
                 anim.SetBool("sitting",false);
                 transform.position = new Vector3(-156.3f, 1.0f, -53f);
            }
        }
        
      }  
}
