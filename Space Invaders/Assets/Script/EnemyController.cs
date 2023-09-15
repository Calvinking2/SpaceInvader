using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public float EnemySpeed;
    private Rigidbody2D rb;
    private Vector2 EnemyMovement;

    void Update()
    {
        transform.Translate(Vector2.right*EnemySpeed*Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            EnemySpeed *= -1;
        }
    }
}
