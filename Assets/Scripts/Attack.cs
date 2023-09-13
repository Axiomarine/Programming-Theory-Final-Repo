using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Attack : MonoBehaviour
{
    protected float topBound = 30;
    protected float speed = 20.0f;

    private int attackDamage = 3;

    private void Update()
    {
        ArrowFly();
    }
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
