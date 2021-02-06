using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    CapsuleCollider2D playerColider;

    Rigidbody2D rb2d;

    public float speed = 50.0f;

    public float lifeTime = 2;
    public bool enemi = false;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerColider = GetComponent<CapsuleCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }


    void FixedUpdate()
    {
        if (!enemi)
        {
            rb2d.AddForce(new Vector2(speed, 0));
        }
        else
        {
            rb2d.AddForce(new Vector2(-speed, 0));
        }
    }
}
