using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLM;
    private SpriteRenderer sr;
    private Rigidbody2D rb2d;
    private BoxCollider2D bc2D;
    public GameObject thePrefab;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        bc2D = GetComponent<BoxCollider2D>();
    }

    public Vector2 speed = new Vector2(50, 50);

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = transform.position;
            pos.x += 1f;
            var instance = Instantiate(thePrefab, pos, transform.rotation);
        }
        if (IsGrounded()&&(Input.GetKeyDown(KeyCode.Space)))
        {
            float jumpVelocity = 10f;
            rb2d.velocity = Vector2.up * jumpVelocity;
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D rch2D = Physics2D.BoxCast(bc2D.bounds.center, bc2D.bounds.size, 0f, Vector2.down, 1/10f, platformsLM);
        Debug.Log(rch2D.collider);
        return rch2D.collider != null;
    }

}

