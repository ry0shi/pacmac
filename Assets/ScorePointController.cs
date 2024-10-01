using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePointController : MonoBehaviour
{
    PacmacController _pacmac;

    void Start()
    {
        _pacmac = GameObject.Find("Pacmac").GetComponent<PacmacController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _pacmac.GetScores();
            GameObject.Find("EnemyRed").GetComponent<Pathfinding.AIPath>().maxSpeed += 0.01f;
            GameObject.Find("EnemyGreen").GetComponent<Pathfinding.AIPath>().maxSpeed += 0.01f;
            GameObject.Find("EnemyCyan").GetComponent<Pathfinding.AIPath>().maxSpeed += 0.01f;
            Destroy(this.gameObject);
        }
    }
}
