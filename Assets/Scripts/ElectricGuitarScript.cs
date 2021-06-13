using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricGuitarScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    bool isPressed = false;
    public GameObject guitar;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool p = Input.GetKeyDown("p");
        if (p == true && isPressed == false)
        {
            anim.GetComponent<Animator>().enabled = true;
            isPressed = true;
        }
        else if (p == true && isPressed == true)
        {
            anim.GetComponent<Animator>().enabled = false;
            isPressed = false;
        }
    }
}
