using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 10.0f;
    private float lowerBond = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        DestroyOutOfBond();

    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
    }

    void DestroyOutOfBond()
    {
        if (transform.position.z < lowerBond)
        {
            Destroy(gameObject);
        }
    }
}
