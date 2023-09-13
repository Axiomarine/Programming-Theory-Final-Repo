using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    private float speedModif = 1.5f;
    void Awake()
    {
        DestroyOutOfBond();
    }

    private void Update()
    {
        MoveForward();
    }

    protected override void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed * speedModif);
    }

    // Update is called once per frame
    protected override void AttackPlayer()
    {
        //Collision serves as the attack
    }
}
