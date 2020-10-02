using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 2f;
    public float startPos;

    Vector2 currentPos;

    // Update is called once per frame

    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameController controller = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
        controller.KilledEnemy();
        Destroy(gameObject);
    }

    public void Update()
    {
        rb.AddForce(Vector2.down * moveSpeed * Time.fixedDeltaTime);

        currentPos = rb.transform.position;
        if (currentPos.y < -9)
        {
            GameController controller = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
            controller.KilledEnemy();
            Destroy(gameObject);
        }
    }
}
