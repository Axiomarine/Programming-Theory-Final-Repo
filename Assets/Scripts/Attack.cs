using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Attack : MonoBehaviour
{
    private float topBound = 30;
    public float speed = 20.0f;

    private void Update()
    {
        ArrowFly();
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
    public void ArrowFly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHP>().GettingDamage(1);
            Destroy(gameObject);
        }
    }
}
