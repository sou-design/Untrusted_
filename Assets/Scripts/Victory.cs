using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    
    public void exit()
    {
        Application.Quit();
    }
    public void replay()
    {
        //set gameobject to true
        gameObject.SetActive(false);
        //Replay
        SceneManager.LoadScene(0);
    }
    
}
