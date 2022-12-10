using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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
        Body();
        Head();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Lobby")
        {
            RotatePlayer();
        }
    }

    void Body()
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

    void Head()
    {
        //referencing the input axis from the input manager
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalRotation * mouseSensitivity, 0); //rotate the player transform around the Y-axis based on MouseX movement
        Camera.main.transform.Rotate(-verticalRotation * mouseSensitivity, 0, 0); //only rotating the camera

    }

    void RotatePlayer()
    {
        transform.LookAt(new Vector3(toLookAt.position.x, transform.position.y, toLookAt.position.z));
        Camera.main.transform.LookAt(toLookAt);
    }



}