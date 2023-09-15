using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    [SerializeField] public float fireDelay = 0.5f;
    private float timer = 0f;
    public GameObject shootSFX;


    void Start()
    {
      
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && timer >= fireDelay) {
            timer = 0f;
            GameObject hitSFX = Instantiate(shootSFX, transform.position,Quaternion.identity);
            Destroy(hitSFX, 2.5f);
            GameObject Fire = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Destroy(Fire, 2f);

        }
    }
}
