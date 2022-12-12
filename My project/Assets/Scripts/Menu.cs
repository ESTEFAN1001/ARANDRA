using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
     public void Play()
    {
        SceneManager.LoadScene("SpeedRun");
    }

    // Update is called once per frame
    public void Salir()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
