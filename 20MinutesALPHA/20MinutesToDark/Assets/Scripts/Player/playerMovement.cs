using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.0F;
   //public float jumpSpeed = 8.0F;
   //public float sprintSpeed = 7.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8;
        }
        else if (Input.GetKey(KeyCode.RightShift))
        {
            speed = 8;
        }
        else
            speed = 5;

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            /*
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
                */
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
}
