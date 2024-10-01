using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    int pacmacLives;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pacmacLives = GameObject.Find("Pacmac").GetComponent<PacmacController>().lives;
        GetComponent<Text>().text = "Lives: " + pacmacLives;
    }
}
