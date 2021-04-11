using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController cont;

    public GameObject projectile;

    public Transform projectilePosition;    //projectile's position is set to the player's position in the inspector, so it looks like the player is firing the projectile

    public Vector3 direction;

    private float speed = 15f;
    public float gravity;
    public float jumpingHeight;

    Vector3 velocity;

    Touch initTouch;

    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, 0f).normalized;

        if (direction.magnitude >= 0.1f)
        {

            cont.Move(direction * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown("q"))    //generating a projectile
        {

            Instantiate(projectile, projectilePosition.position, projectilePosition.rotation);
        }

        if (Input.GetKeyUp("g"))  //jump
        {

            velocity.y = Mathf.Sqrt(jumpingHeight * -2f * gravity); //jump velocity
        }

        velocity.y += gravity * Time.deltaTime;       //freefall velocity
        cont.Move(velocity * Time.deltaTime);
    }
}
