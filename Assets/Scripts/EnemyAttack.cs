using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : Attack
{

    // Update is called once per frame
    void Update()
    {
        ArrowFly();
    }

    protected override void ArrowFly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        if (transform.position.z < -topBound)
        {
            Destroy(gameObject);
        }
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
