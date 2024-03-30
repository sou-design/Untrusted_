using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour
{
    public GameObject Solution;
    void OnMouseDown()
    {
        if (Solution != null) 
        { 
        // this object was clicked - do something
        Solution.SetActive(true);
        }
    }
}
