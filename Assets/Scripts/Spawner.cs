using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public int bombChance = 20;
    public GameObject fruitPrefab;
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", 0f, spawnSpeed);
    }
    void Update()
    {
        if (transform.position.y < -6)
        {
            print("fail");
            Destroy(fruitPrefab);
        }
    }

    void SpawnFruit()
    {
        var prefab = Random.Range(0, 100) > bombChance ? fruitPrefab : bomb;
        int fruitpos = Random.Range(-5, 5);
        Instantiate(prefab, new Vector3(fruitpos, -5, 0), Quaternion.identity);
    }
}
