using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform enemy;

    [SerializeField] private float playerCloseEnoughTOChase = 2.7f;
    [SerializeField] private float playerCloseEnoughTOAttack = 1.125f;


}
