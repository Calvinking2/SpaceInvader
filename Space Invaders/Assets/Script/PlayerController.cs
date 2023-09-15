using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] public float PlayerSpeed;
    private Rigidbody2D rb;
    private Vector2 PlayerMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        PlayerMovement = new Vector2(direction,0);
    }
    private void FixedUpdate()
    {
        rb.velocity = PlayerMovement * PlayerSpeed;
    }
}
