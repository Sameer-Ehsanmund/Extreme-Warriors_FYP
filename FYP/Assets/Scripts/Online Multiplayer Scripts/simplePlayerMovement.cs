using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplePlayerMovement : Photon.MonoBehaviour
{
    public CharacterController cont;

    public Vector3 direction;

    private float speed = 15f;
    private float gravity = -9.8f;
    private float jumpingHeight = 3f;

    Vector3 velocity;

    public GameObject playerCamera;

    public PhotonView PhV;

    private void Awake()
    {

        if (photonView.isMine)
        {
            Debug.Log("SHOWN");
            playerCamera.SetActive(true);
        }
    }

    private void CheckInput()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");

        direction = new Vector3(horizontal, 0f, 0f).normalized;

        if (direction.magnitude >= 0.1f)
        {

            cont.Move(direction * speed * Time.deltaTime);
        }

        if (Input.GetKeyUp("g"))  //jump
        {

            velocity.y = Mathf.Sqrt(jumpingHeight * -2f * gravity); //jump velocity
        }

        velocity.y += gravity * Time.deltaTime;       //freefall velocity
        cont.Move(velocity * Time.deltaTime);
    }

    void Update()
    {

        if (photonView.isMine)
        {

            CheckInput();
        }

        
    }
}
