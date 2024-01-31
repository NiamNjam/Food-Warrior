using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pear;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", 2f, 2f);
    }
    void Update()
    {
        if (transform.position.y < -6)
        {
            print("fail");
            Destroy(pear);
        }
    }

    void SpawnFruit()
    {
        int fruitpos = Random.Range(-5, 5);
        Instantiate(pear, new Vector3(fruitpos, -5, 0), Quaternion.identity);
    }
}
