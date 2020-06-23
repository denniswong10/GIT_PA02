using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawn : MonoBehaviour
{
    public int speed;
    public float SpawnInterval;
    private float NextSpawn = 0;

    public GameObject[] Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        NextSpawn = Time.time + SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnInterval;
            Instantiate(Obstacle[Random.Range(0, Obstacle.Length)], new Vector3 (Random.Range(-1.5f, 1.5f), transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
