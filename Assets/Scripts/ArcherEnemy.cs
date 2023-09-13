using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherEnemy : Enemy
{
    public GameObject projectilePrefab;
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
        MoveForward();
    }
    protected override void AttackPlayer()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}