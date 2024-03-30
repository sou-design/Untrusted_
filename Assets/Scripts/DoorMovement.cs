using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public GameObject door_opened, door_closed, lockedText,level1,Timer;
    public bool isOpen; 
    bool locked;
    public AudioSource DoorSound;
    public static DoorMovement instance { get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }
    private void Start()
    {
        locked = true;
        DoorSound.enabled = false;
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lockedText.SetActive(true);
            if (isOpen == false)
            {
                if (Puzzle.instance.vic == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {Debug.Log("Close the door ...");
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        StartCoroutine(repeat());
                        isOpen = true;
                        DoorSound.enabled = true;
                        level1.SetActive(true);
                        Timer.SetActive(false);
                        lockedText.SetActive(false);
                    }
                }
            }
        }
    }
    IEnumerator repeat()
    {
        yield return new WaitForSeconds(4.0f);
        DoorSound.enabled = false;
    }
    void OnTriggerExit(Collider other)
    {
        
        lockedText.SetActive(false);
    }
}
