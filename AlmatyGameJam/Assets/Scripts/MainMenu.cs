using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject startb;
    public GameObject quitb;
    public GameObject setttings;
    public GameObject setmenu;
    public GameObject exitb;

    public void Startm()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1;
    }

    public void Quitm()
    {
        Application.Quit();
        print("quitted");
    }

    public void Setm()
    {
        setmenu.SetActive(true);
    }
    public void Exit()
    {
        setmenu.SetActive(false);
    }
}