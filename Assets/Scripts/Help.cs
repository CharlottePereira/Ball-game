using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Help : MonoBehaviour
{



    public string LevelToLoad = "Help";

    public void PlayHelp()
    {
        SceneManager.LoadScene(LevelToLoad);
    }




}

// faire en sorte que  echap = quitter le menu + pareil en jeu