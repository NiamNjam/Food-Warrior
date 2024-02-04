using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(7f, 13f));
        rb.angularVelocity = Random.Range(-360, 360);
        
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
            print("fail");
            Destroy(gameObject);
        }
    }

    
}
