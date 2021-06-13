using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenue : MonoBehaviour
{
	public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject MoreInfoMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
       SceneManager.LoadScene("Shop");
    }
    public void BackButton()
    {
       	MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        MoreInfoMenu.SetActive(false);
    }
    public void CreditsButton()
    {
        CreditsMenu.SetActive(true);
        MainMenu.SetActive(false);
        MoreInfoMenu.SetActive(false);
    }
    public void MoreInfoButton()
    {
    	MoreInfoMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        MainMenu.SetActive(false);
        
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
    }

    public void MuteButton()
    {
        if(AudioListener.volume>0.2)
            AudioListener.volume = 0;
        else {
            AudioListener.volume = 1;
        }
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}
