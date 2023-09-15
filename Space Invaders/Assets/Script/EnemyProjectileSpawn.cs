using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileSpawn : MonoBehaviour
{
    public GameObject EnemyProjectile;
    public float spawnTimer;
    [SerializeField]public float spawnMax = 10;
    [SerializeField]public float spawnMin = 5;
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            GameObject enemyProjectile =  Instantiate(EnemyProjectile, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
            Destroy(enemyProjectile, 3f);
        }

    }
}
