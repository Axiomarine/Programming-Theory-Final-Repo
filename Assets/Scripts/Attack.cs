using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Attack : MonoBehaviour
{
    // ENCAPSULATION
    protected float topBound { get; private set; } = 30;
    protected float speed { get; private set; } = 20.0f;

    private int attackDamage = 3;

    private void Update()
    {
        ArrowFly();
    }

    // ABSTRACTION
    protected virtual void ArrowFly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHP>().GettingDamage(attackDamage);
            Destroy(gameObject);
        }
    }
}
