using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    SpriteRenderer sr;
    Rigidbody2D rb2d;
    public GameObject thePrefab;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    public Vector2 speed = new Vector2(50, 50);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            var pos = transform.position;
            pos.x += 1f;
            var instance = Instantiate(thePrefab, pos, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed.x, 0.8f)
                                    , Mathf.Lerp(0, 0, 0.8f));
    }

}

