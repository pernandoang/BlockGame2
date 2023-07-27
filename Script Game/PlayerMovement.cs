using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float runSpeed = 40f;

    float horizontalMove = 0f ;
    bool jump = false;
    bool crounch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crounch"))
        {
            crounch = true;
        }else if (Input.GetButtonUp("Crounch"))
        {
            crounch = false; 
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crounch, jump);
        jump = false;
    }
}
