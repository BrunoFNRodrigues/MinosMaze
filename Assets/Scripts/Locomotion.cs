
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Valve.VR;

using Valve.VR.InteractionSystem;


public class Locomotion : MonoBehaviour

{

    private CharacterController controller;

    private Vector3 playerVelocity;

    private bool groundedPlayer;

    private float playerSpeed = 2.0f;

    private float gravityValue = -9.81f;



    public SteamVR_ActionSet actionSet;


    public SteamVR_Action_Vector2 moveAction;

   

    public SteamVR_Input_Sources hand;


    private void Start()

    {

        controller = gameObject.GetComponent<CharacterController>();

        actionSet.Activate(hand);

    }


    void Update()

    {


        // Posição do gamepad

        Vector2 m = moveAction[hand].axis;

       

        groundedPlayer = controller.isGrounded;

       

        if (groundedPlayer && playerVelocity.y < 0)

        {

            playerVelocity.y = 0f;

        }


        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


        Vector3 move = new Vector3(m.x, 0, m.y);


        controller.Move(move * Time.deltaTime * playerSpeed);


        if (move != Vector3.zero)

        {

            gameObject.transform.forward = move;

        }


        playerVelocity.y += gravityValue * Time.deltaTime;

        controller.Move(playerVelocity * Time.deltaTime);

    }

}