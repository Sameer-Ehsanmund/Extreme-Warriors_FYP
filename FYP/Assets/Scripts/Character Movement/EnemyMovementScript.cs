using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{

    public CharacterController cont;

    public Transform PlayerPosition;
    public Transform EnemyPosition;

    private float distanceforchasing = 12f;
    private float distanceforAttacking = 5f;
    private float EnemySpeed = 6f;
    private float EnemySmoothedSpeed = 0.125f;

  

    void FixedUpdate()
    {

        float distancebetweenEnemyandPlayer = Vector3.Distance(PlayerPosition.position, EnemyPosition.position);
        Debug.Log(distancebetweenEnemyandPlayer);

        if (distancebetweenEnemyandPlayer <= distanceforchasing)         //enemy chases the player
        {

            Vector3 direction = PlayerPosition.position - transform.position;
            direction = direction.normalized;
            Vector3 velocity = direction * EnemySpeed;
            cont.Move(velocity * Time.deltaTime);
        }

        if (distancebetweenEnemyandPlayer <= distanceforAttacking)         
        {

            Debug.Log("Attacking Player");
        }

        else
        {

            Vector3 originalPosofEnemy = new Vector3(5.7f, 2.1f, -0.5f);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, originalPosofEnemy, EnemySmoothedSpeed);
            transform.position = smoothedPosition;
        }
    }
}
