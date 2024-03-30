using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public int TurnX;
    public int TurnY;
    public int TurnZ;

    public int MoveX;
    public int MoveY;
    public int MoveZ;

    public bool World;

    private bool IsGameRunning = false;

    // Use this for initialization
    void Start()
    {
        IsGameRunning = true;
      
    }

    // Update is called once per frame
    void Update()
    {

          float rotation =   Time.deltaTime * 30;
          transform.Rotate(0, 0, rotation);
  
     }

}
 

