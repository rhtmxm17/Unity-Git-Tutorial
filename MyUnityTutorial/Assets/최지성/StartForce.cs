﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce : MonoBehaviour
{
    // 주석 추가하기
    public Vector3 speed;
    public Rigidbody target;

    // Start is called before the first frame update
    void Start()
    {
        target.AddRelativeForce(speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
