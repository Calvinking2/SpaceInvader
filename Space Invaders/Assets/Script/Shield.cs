using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int shields = 3;
    public Sprite extra2;
    public Sprite extra3;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.gameObject);
            shields -= 1;
            if(shields == 2)
            {
                spriteRenderer.sprite = extra2;
            }
            else if (shields <= 0)
            {
                Destroy(gameObject);

            }else if(shields == 1)
            {
                spriteRenderer.sprite = extra3;
            }
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            shields -= 1;

            if (shields == 2)
            {
                spriteRenderer.sprite = extra2;
            }
            else if (shields <= 0)
            {
                Destroy(gameObject);

            }
            else if (shields == 1)
            {
                spriteRenderer.sprite = extra3;
            }
        }
        else
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
