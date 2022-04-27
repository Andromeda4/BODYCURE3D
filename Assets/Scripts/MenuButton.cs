using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void ControlsMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene(6);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
} 

