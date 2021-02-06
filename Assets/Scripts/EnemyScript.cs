using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb2d;
    public GameObject thePrefab;
    Vector2 speed = new Vector2(0,10);
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        print(rb2d.position.x);
        if (((screenPoint.y >= 1)&&(speed.y > 0)) || ((screenPoint.y <= 0) && (speed.y < 0)))
            speed.y *= -1;
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0, Mathf.Lerp(0, speed.y, 0.8f));
    }
}
