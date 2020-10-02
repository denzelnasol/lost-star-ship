using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Vector2 currentPos;

    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision) {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.25f);
        Destroy(gameObject);
    }

    public void Update()
    {
        currentPos = transform.position;
        if (currentPos.y > 8)
        {
            Destroy(gameObject);
        }
    }
}
