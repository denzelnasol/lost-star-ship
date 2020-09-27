using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 20f;
    public float startPos;

    // Update is called once per frame

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position.x;
    }
    public void Update()
    {
        rb.AddForce(Vector2.down * moveSpeed * Time.fixedDeltaTime);
    }
}
