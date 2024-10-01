using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescan : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Rescan());
    }

    IEnumerator Rescan()
    {
        yield return new WaitForSeconds(10.1f);
        GetComponent<AstarPath>().Scan();
    }
}
