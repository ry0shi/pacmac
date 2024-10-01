using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Count_down());
    }

    IEnumerator Count_down()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }
}
