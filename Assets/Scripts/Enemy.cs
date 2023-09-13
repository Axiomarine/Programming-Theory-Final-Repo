using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float speed = 5.0f;
    private float lowerBond = -10.0f;

    protected virtual void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        Debug.Log("Moving");
    }

    protected void DestroyOutOfBond()
    {
        if (transform.position.z < lowerBond)
        {
            Destroy(gameObject);
        }
    }

    protected abstract void AttackPlayer();

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with the enemy!!!");
            Destroy(gameObject);
        }
    }
}
