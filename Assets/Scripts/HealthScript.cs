using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public int hp = 1;
    void OnCollisionEnter2D(Collision2D coll)

    {
        Debug.Log("test");
        var collider = coll.collider;
        LaserScript shot = collider.gameObject.GetComponent<LaserScript>();
        if (shot != null)
        {
            ///lol
                hp -= shot.damage;
            Destroy(shot.gameObject);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
