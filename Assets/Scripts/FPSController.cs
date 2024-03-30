using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour

{ 
    private CharacterController controller;
    public AudioSource walk;
    public float speed;
    public AudioClip footstepSound;
    private float footstepTimer = 0f;
    public float footstepInterval = 0.5f;

    void Start()
    {

        //initialisation
        speed = 20f;
        controller = GetComponent<CharacterController>();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //Modify speed
        if (Input.GetKey(KeyCode.W))
        {
            speed += 0.03f;
        }
        else if (Input.GetKey(KeyCode.S))
        { 
            speed -= 0.03f; 
        }
        //mouvement horizontal et vertical 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Sound
        if (horizontalInput != 0 || verticalInput != 0)
        {
            walk.enabled = true;
            PlayFootstepSound();
           
        }
        else
        {
            walk.enabled = false;
        }

        Vector3 move = transform.forward * horizontalInput - transform.right * verticalInput;

        controller.Move(move * speed * Time.deltaTime);

    }
 //Play sound
    void PlayFootstepSound()
    {
        Debug.Log("Playing footstep sound");
        footstepTimer += Time.deltaTime;

        if (footstepTimer >= footstepInterval)
        {
            // Jouer le son de pas.
            if (footstepSound != null)
            {
                walk.PlayOneShot(footstepSound);
            }

            footstepTimer = 0f;
        }
    }
}
