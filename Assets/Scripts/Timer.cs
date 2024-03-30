using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextTime;
    float usedTime = 0f;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        usedTime += Time.deltaTime;
        int mnt =Mathf.FloorToInt(usedTime/60);
        int sec = Mathf.FloorToInt(usedTime % 60);
        TextTime.text = string.Format("{0:00}:{1:00}",mnt,sec);
    }
}
