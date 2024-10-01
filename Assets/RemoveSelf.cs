using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSelf : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D))
        Destroy(this.gameObject);
    }
}
