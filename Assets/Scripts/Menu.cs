using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    public string LevelToLoad = "Jeu";
  
    public void PlayGame()
    {
        SceneManager.LoadScene(LevelToLoad);
    }



    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

}
