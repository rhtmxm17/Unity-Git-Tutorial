using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public int movePower;
    

    public Rigidbody rigidbody;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            rigidbody.AddForce(Vector3.left * movePower, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.RightArrow))
            rigidbody.AddForce(Vector3.right * movePower, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.UpArrow))
            rigidbody.AddForce(Vector3.forward * movePower, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.DownArrow))
            rigidbody.AddForce(Vector3.back * movePower, ForceMode.Acceleration);

    }
}
