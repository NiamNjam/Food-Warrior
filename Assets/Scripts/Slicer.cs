using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldpos.z = 0;
        transform.position = worldpos;
        rb.MovePosition(worldpos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("touched");
        Destroy(collision.gameObject);
    }
}
