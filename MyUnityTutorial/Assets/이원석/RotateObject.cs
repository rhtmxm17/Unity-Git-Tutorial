using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, horizontal * rotationSpeed * Time.deltaTime, 0));
    }
}
