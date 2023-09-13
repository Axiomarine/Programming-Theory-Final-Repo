using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class EnemyAttack : Attack
{

    // Update is called once per frame
    void Update()
    {
        ArrowFly();
    }

    // POLYMORPHISM
    // changes direction and boundaries for enemy's arrows
    protected override void ArrowFly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        if (transform.position.z < -topBound)
        {
            Destroy(gameObject);
        }
    }

    // POLYMORPHISM
    // destroys player, not the enemy after colliding
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
