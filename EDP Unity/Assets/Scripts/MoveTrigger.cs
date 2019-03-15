using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;


    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha1))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha2))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha3))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

