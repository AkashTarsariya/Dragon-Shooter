using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Vector2 StartingVelocity;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();
        
        Destroy(gameObject);
    }
}
