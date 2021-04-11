using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playergettingHit : MonoBehaviour
{

    public CharacterController cont;

    public float totalHealth;
    public float remainingHealth;

    public Image healthBar;

    public bool ifenemycollidesPlayer;

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.transform.tag == "enemyPunch")
        {

            totalHealth -= 2f;
            remainingHealth = totalHealth;
            healthBar.fillAmount -= 0.02f;
            playerDies();
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "enemyPunch")
        {
            Debug.Log("punched");
            ifenemycollidesPlayer = true;
        }
        else
        {
            Debug.Log("not punched");
            ifenemycollidesPlayer = false;
        }
    }

    void playerDies()
    {

        if (totalHealth == 0f)
        {

            Destroy(gameObject);
        }
    }
}
