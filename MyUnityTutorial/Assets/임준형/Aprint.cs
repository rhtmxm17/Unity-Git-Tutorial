using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aprint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("A"))
        {
            Debug.Log("A를 밟았습니다!");
        }
    }
}
