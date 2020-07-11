using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject tittleMenu;
    public GameObject creditsMenu;

    public void Back()
    {
        if (creditsMenu.activeInHierarchy)
        {
            creditsMenu.SetActive(false);
        }
        
        tittleMenu.SetActive(true);
    }


    public void GoCreditsMenu()
    {
        tittleMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

  
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }



    public void Quit()
    {
        Application.Quit();
    }
}
