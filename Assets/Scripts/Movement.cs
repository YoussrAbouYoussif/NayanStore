using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator anim;
    public int  rotation_factor =100;
    float time_in_seconds = 0.0f;
    int count = 0;
    int current_instrument = 1;
    public GameObject ButtonsMenu;
    public GameObject PauseMenu;
    public GameObject NextButton_;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        transform.Rotate(0, -85, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.N))
        {
            NextButton();
        }
        
        
    }

    void FixedUpdate()
    {
        time_in_seconds += Time.deltaTime;
     
        if(count >=16){
             anim.SetBool("Move",false);
        }

        int x =(int) time_in_seconds ; 
        if(count < 16 && current_instrument==1){
            transform.Translate(1.8f, 0,0.05f);
            count += 1;
        }
        else
        {
            if(count < 16 && current_instrument==2)
            {
                transform.Translate(3.234f, 0,0.5f);
                rotate(count);
                count += 1;
            }
            else
            {
                if(count < 16 && current_instrument==3)
                {
                    transform.Translate(2.954f, 0,0.35f);
                    rotate(count);
                    count += 1;
                }
                else
                {
                    if(count < 16 && current_instrument==4)
                    {
                        transform.Translate(2.654f, 0,0.35f);
                        rotate(count);
                        count += 1;
                    }
                    else
                    {
                        if(count < 16 && current_instrument==5)
                        {
                            transform.Translate(2.65f, 0,0.35f);
                            rotate(count);
                            count += 1;
                        }
                        else
                        {
                            if(count < 16 && current_instrument==6)
                            {
                                transform.Translate(2.85f, 0,0.35f);
                                rotate(count);
                                count += 1;
                            }
                        }
                    }
                }
            }
        }
        // Debug.Log("Motion: "+ x);
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Shop");
    }
    public void rotate(int count){
        if(count < 8)
        {
            transform.Rotate(0, 1.0f, 0);
        }
        else
        {
            transform.Rotate(0, -1.0f, 0);
        }
    }

    public void NextButton()
    {
        count = 0;
        current_instrument += 1;
        if(current_instrument == 6)
        {
            NextButton_.SetActive(false);
        }
        anim.SetBool("Move",true);
    }
    public void PlayButton()
    {
        // Here You Have instrument count instrument
        // current_instrument

        if(current_instrument==1)
        {
            SceneManager.LoadScene("Piano");
        }
        if (current_instrument == 2)
        {
            SceneManager.LoadScene("Singing");
        }
        if (current_instrument == 3)
        {
            SceneManager.LoadScene("GuitarScene");
        }
        if(current_instrument == 4)
        {
            SceneManager.LoadScene("PlayingDrums");
        }
        if(current_instrument == 5)
        {
            SceneManager.LoadScene("Violin");
        }
        if(current_instrument == 6)
        {
            SceneManager.LoadScene("Flute");
        }

    }
    public void ResumeButton()
    {
        ButtonsMenu.SetActive(true);
        PauseMenu.SetActive(false);  
        Time.timeScale = 1;
    }
    public void PauseButton()
    {
        PauseMenu.SetActive(true);
        ButtonsMenu.SetActive(false);
        Time.timeScale = 0;
    }
       public void QuitButton()
    {
        // Quit Game
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menue");
    }
}
