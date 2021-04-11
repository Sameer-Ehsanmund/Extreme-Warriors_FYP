using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public CharacterController cont;

    public float speed;   // the projectile's speed
    private float lifespan = 2f;   // the projectile's life span (in seconds)

    GameObject enemy;

    private Transform target;

    void Start()
    {

        enemy = GameObject.FindWithTag("Enemy");
        target = enemy.transform;
    }

    void FixedUpdate()   //projectile trajectory and movement (implementation 1)
    {

        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        Vector3 velocity = direction * speed;
        cont.Move(velocity * Time.deltaTime);
        Destroy(gameObject, lifespan);
    }
}
