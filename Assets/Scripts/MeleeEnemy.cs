using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MeleeEnemy : Enemy
{
    private float speedModif = 1.5f; //speed of the enemy should be increased
    void Awake()
    {
        DestroyOutOfBond();
    }

    private void Update()
    {
        MoveForward();
    }

    // POLYMORPHISM
    protected override void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed * speedModif);
    }

    protected override void AttackPlayer()
    {
        //Collision serves as the attack
    }
}
