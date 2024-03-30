using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        
        Debug.Log("Starting the game ...");

        // Charge la scène suivante dans l'ordre de la build.
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        
        Debug.Log("Quit the game :(");

        // Quitte l'application.
        Application.Quit();
    }
}
