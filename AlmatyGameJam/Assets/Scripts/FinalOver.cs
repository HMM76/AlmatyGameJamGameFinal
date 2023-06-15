using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalOver : MonoBehaviour
{
    public GameObject restartb;
    public GameObject quitb;
    private void Start()
    {
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene("StartScene");
        GameManager.instance.OnMainActivate();
        Time.timeScale = 1;
        print("qt");
    }
}
