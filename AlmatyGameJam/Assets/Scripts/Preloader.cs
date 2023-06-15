using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour
{
    // Start is called before the first frame update

    private CanvasGroup introGroup;
    private float loadTime;
    private float minimumLogoTime = 3;
    void Start()
    {
        introGroup = FindObjectOfType<CanvasGroup>();

        introGroup.alpha = 1;

        if(Time.time < minimumLogoTime)
        {
            loadTime = minimumLogoTime;
        }
        else
        {
            loadTime = Time.time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time > minimumLogoTime)
        {
            
        
            if(introGroup.alpha >= 1)
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
