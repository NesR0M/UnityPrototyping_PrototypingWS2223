using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement_BM : MonoBehaviour
{
    public float Speed = 5f;
   
    public float gravity = 9.87f;
    public float verticalSpeed = 0.0f;

    public float mouseSensitivity = 2.0f;

    private CharacterController _controller;

    public Transform toLookAt;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
   
    void Update()
    {
        MyMovement();
        MyRotate();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Lobby")
        {
            RotateHead();
        }
    }

    void MyMovement()
    {
        //referencing the input axis from the input manager
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        //check if _controller is grounded...if not...calculate vertical speed
        if (_controller.isGrounded)
            verticalSpeed = 0.0f;
        else
            verticalSpeed -= gravity * Time.deltaTime;

        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0); //calculate gravity as a new vector3
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove; 
        _controller.Move(move * Speed * Time.deltaTime + gravityMove * Speed * Time.deltaTime); //move the _controller + add gravity
    }

    void MyRotate()
    {
        //referencing the input axis from the input manager
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalRotation * mouseSensitivity, 0); //rotate the player transform around the Y-axis based on MouseX movement
        Camera.main.transform.Rotate(-verticalRotation * mouseSensitivity, 0, 0); //only rotating the camera

    }

    void RotateHead()
    {
        Debug.Log("Head should rotate");

        /*
         * Vector3 targetDirection = toLookAt.position - transform.position;
         * Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, Speed, 0.0f);
         * transform.rotation = Quaternion.LookRotation(newDirection);
         * Camera.main.transform.rotation = Quaternion.LookRotation(newDirection);
        */

        //Vector3 bodyRotation = new Vector3(0.956178606f, 172.906647f, 359.780212f);
        //Vector3 cameraRotation = new Vector3(0.0267419815f, 1.4024086f, 0.150000006f);

        transform.LookAt(toLookAt);
        Camera.main.transform.LookAt(toLookAt);
    }



}