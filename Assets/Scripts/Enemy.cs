using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // ENCAPSULATION
    protected float speed { get; private set; } = 5.0f; //the variable will be used during overriding
    private float lowerBond = -10.0f;

    // ABSTRACTION
    protected virtual void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
    }

    protected void DestroyOutOfBond()
    {
        if (transform.position.z < lowerBond)
        {
            Destroy(gameObject);
        }
    }

    protected abstract void AttackPlayer();

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with the enemy!!!");
            Destroy(other.gameObject);
        }
    }
}
