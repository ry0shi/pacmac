using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PacmacController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;
    Rigidbody2D rb;
    Vector3 input;
    [SerializeField]
    int score = 0;
    [SerializeField]
    public int lives = 3;
    [SerializeField]
    GameObject wMessage;
    [SerializeField]
    GameObject lMessage;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            input = Vector3.right;
        else if (Input.GetKeyDown(KeyCode.A))
            input = Vector3.left;
        else if (Input.GetKeyDown(KeyCode.W))
            input = Vector3.up;
        else if (Input.GetKeyDown(KeyCode.S))
            input = Vector3.down;

        rb.MovePosition(transform.position + input * movementSpeed * Time.deltaTime);  

        if (Input.GetKeyDown(KeyCode.R))
        SceneManager.LoadScene(0);     
    }

    public void GetScores()
    {
        score += 1;

        if (score == 112)
        {
            wMessage.GetComponent<Setactive>().setaCtive();
            rb.bodyType = RigidbodyType2D.Static;
            Destroy(GameObject.Find("EnemyRed"));
            Destroy(GameObject.Find("EnemyGreen"));
            Destroy(GameObject.Find("EnemyCyan"));
        }
        // go to win scene

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        lives -= 1;

        if (lives <= 0)
        // you lose 
        {
            rb.bodyType = RigidbodyType2D.Static;
            
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            lMessage.SetActive(true);
            Destroy(this.gameObject, 1);
        }
    }
}
