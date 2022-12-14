using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
   
    public float gravity = 9.87f;
    public float verticalSpeed = 0.0f;

    public float mouseSensitivity = 2.0f;

    private CharacterController _controller;

    public Transform toLookAt;

    public bool visitedHCIInfoscreenBefore = false;

    public GameObject floorlights;

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
        if (other.tag == "Lobby")
        {
            RotatePlayer();
        }

        if (other.tag == "HCI_Infoscreen_Trigger")
        {
            visitedHCIInfoscreenBefore = true;

            if (floorlights != null)
            {
                floorlights.SetActive(true);
            }
        }

        if (other.tag == "changeRoom" && visitedHCIInfoscreenBefore)
        {
            SceneManager.LoadScene("HCI_LAB_ROOM");
        }
    }

    void Body()
    {
        
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        
        if (_controller.isGrounded)
            verticalSpeed = 0.0f;
        else
            verticalSpeed -= gravity * Time.deltaTime;

        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove; 
        _controller.Move(move * Speed * Time.deltaTime + gravityMove * Speed * Time.deltaTime); 
    }

    void Head()
    {
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalRotation * mouseSensitivity, 0); 
        Camera.main.transform.Rotate(-verticalRotation * mouseSensitivity, 0, 0); 

    }

    void RotatePlayer()
    {
        transform.LookAt(new Vector3(toLookAt.position.x, transform.position.y, toLookAt.position.z));
        Camera.main.transform.LookAt(toLookAt);
    }


}