using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Attack : MonoBehaviour
{
    public float speed = 20.0f;

    private void Update()
    {
        ArrowFly();
    }
    public void ArrowFly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
