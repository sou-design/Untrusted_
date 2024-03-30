using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChaiseMouvement : MonoBehaviour
{
    private int direction=-1;
    public float Vitesse = 1; // on choisit la vitesse de déplacement
    public float pos1X = -1.5f;
    public float pos2X = -2;
    public Vector3 depart = new Vector3(-1, 0, 3);
    public Vector3 arrivee = new Vector3(-2, 0, 3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float temps = Mathf.PingPong(Time.time*1,1);
        transform.position = Vector3.Lerp(depart,arrivee,temps);
    }
}
