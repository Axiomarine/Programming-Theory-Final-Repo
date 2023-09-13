using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// INHERITANCE
public class ArcherEnemy : Enemy
{
    [SerializeField]
    private GameObject projectilePrefab;
    private float startDelay = 0.5f;
    private float repeatRate = 2.0f;
    void Awake()
    {
        // shooting arrows in some intervals
        InvokeRepeating("AttackPlayer", startDelay, repeatRate);
        DestroyOutOfBond();
    }

    private void Update()
    {
        MoveForward(); //moves enemy forward
    }
    // POLYMORPHISM
    protected override void AttackPlayer()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // shoots arrows
    }
}