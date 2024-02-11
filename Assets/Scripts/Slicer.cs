using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    public int comboCount;
    public float comboTimeLeft;
    public AudioClip comboSound;
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
        comboTimeLeft -= Time.deltaTime;
        if (comboTimeLeft <= 0)
        {
            if (comboTimeLeft > 2)
            {
                AudioSystem.Play(comboSound);
            }
            comboCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("touched");
        var food = collision.gameObject.GetComponent<Food>();
        food.Slice();
        comboCount++;
        comboTimeLeft = 0.3f;
    }
}
