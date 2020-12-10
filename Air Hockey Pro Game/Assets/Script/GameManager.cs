using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject menuPanel;
    public GameObject SettingPanel;
    public GameObject inGMenu;
    public GameObject resumeBut;
    public bool isPalying;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isPalying = false;
        Time.timeScale = 0;
        SettingPanel.SetActive(false);
        menuPanel.SetActive(true);
        inGMenu.SetActive(false);
        resumeBut.SetActive(false);
    }


    

    public void Play()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
        resumeBut.SetActive(true);
        isPalying = true;
    }

    public void Back()
    {
        Time.timeScale = 1;
        inGMenu.SetActive(false);
        resumeBut.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Resume()
    {
        Time.timeScale = 0;
        inGMenu.SetActive(true);
        resumeBut.SetActive(false);
    }

    public void Menu()
    {
        menuPanel.SetActive(true);
    }

 
    public void Quit()
    {
        Application.Quit();
    }

    public void Setting()
    {
        SettingPanel.SetActive(true);
       
        
    }

    public void SettingBack()
    {
        SettingPanel.SetActive(false);
        if (isPalying == true)
        {
            resumeBut.SetActive(true);
        }
        else
        {
            resumeBut.SetActive(false);
        }

    }

    public void SoundOn()
    {
        Sound.instance.isSound = true;
    }

    public void SoundOff()
    {
        Sound.instance.isSound = false;
    }

}
