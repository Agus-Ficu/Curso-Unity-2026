using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Force in N/s")]
    private float force = 300;

    private Vector3 moveDirection;
    private float space;
    
    [SerializeField]
    [Tooltip("Torque in N/s")]
    private float torque = 5;

    private float angle;

    private Rigidbody rb;
    
    
    //Vector obtained by the action 'Move' in the input system
    private Vector2 moveInput;
     //Vector obtained by the action 'Look' in the action system
     private Vector2 lookInput;


     void Start()
     {
         Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;
         
         rb = GetComponent<Rigidbody>();

         
     }

     

     void Update()
    {
        //Player Movement
        space = force * Time.deltaTime;
        moveDirection = new Vector3(moveInput.x, 0, moveInput.y).normalized;
        //transform.Translate(moveDirection * space);
        
        
        //Player horizontal rotation
        angle = torque * Time.deltaTime;
        //transform.Rotate(0, lookInput.x*angle, 0);
        
        
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(moveDirection * space);
        rb.AddTorque(0, lookInput.x*angle, 0);
    }


    public void onMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void onLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
}
