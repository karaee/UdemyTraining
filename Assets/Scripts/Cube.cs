using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Awake() {
        Debug.Log("başla");
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("sth inside");
    }
}
