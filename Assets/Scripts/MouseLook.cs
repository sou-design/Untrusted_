using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 10.0f;

        float xRotation = 0.0f;
        float YRotation = 0.0f;

        void Start()
        {
            
           
        }

        void Update()
        {
            Cursor.visible = true;
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            //x Rotation
            xRotation -= mouseY;
            //clamp rotation to not over rotate
            xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
            //y Rotation
            YRotation += mouseX;
            //Apply rotations
            transform.localRotation = Quaternion.Euler(0,YRotation ,xRotation );

        }
    
}
