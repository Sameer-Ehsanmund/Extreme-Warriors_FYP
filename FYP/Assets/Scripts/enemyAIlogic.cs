using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyAIlogic : MonoBehaviour
{
    private Transform target;

    public GameObject player;

    public CharacterController enemy;

    public Image healthBar;
    //public Image healthBarBackground;

    private float enemySpeed = 7f;
    private float smoothSpeed = 0.05f;
    public float totalHealth = 100f;
    public float remainingHealth = 100f;

    public bool ifplayercollides;
    public bool enemycollideswithPlayer;

    void Start()
    {

        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    void FixedUpdate()
    {

        

        if (ifplayercollides == true)   //enemy follows the player
        {
            
            Vector3 direction = target.position - transform.position;
            direction = direction.normalized;
            Vector3 velocity = direction * enemySpeed;
            enemy.Move(velocity * Time.deltaTime);
        }
        
        if (ifplayercollides == false)  //enemy goes back to original position
        {

            Vector3 orgPosition = new Vector3(9.3f, 2.780005f, 2.7f);   //original (start) position of the enemy
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, orgPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {

            ifplayercollides = true;
            FixedUpdate();
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.transform.tag == "Player")
        {

            ifplayercollides = false;
            FixedUpdate();
        }  
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)  //enemy getting punched
    {

        if (hit.transform.tag == "punch")
        {

            totalHealth -= 2f;
            remainingHealth = totalHealth;
            healthBar.fillAmount -= 0.02f;
            //healthBarBackground.color = Color.white;
            enemyDies();
            //Debug.Log("punched..");
        }

        if (hit.transform.tag == "player")
        {

            enemycollideswithPlayer = true;
            Debug.Log("hitt");
        }
    }

    void enemyDies()
    {

        if (totalHealth == 0f)
        {

            Destroy(gameObject);
        }
    }
}