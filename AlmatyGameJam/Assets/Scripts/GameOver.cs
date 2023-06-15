using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject menu;
    public LegensFollow lf;

    public void Restart()
    {
        menu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        GameManager.instance.OnMainActivate();  
        SceneManager.LoadScene("MainGame");      
        Time.timeScale = 1;
        print("quitted");
        lf.npcwait = false;
    }

    public void MenuActivator()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        
    }
}
