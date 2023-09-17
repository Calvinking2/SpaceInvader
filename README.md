# SpaceInvader

<div style="display: flex; justify-content: space-between;">
  <img src="https://github.com/Calvinking2/SpaceInvader/assets/54987031/963afe93-b13b-4fa9-aa1c-ebd187f74517" alt="Image 1" width="45%">
  <img src="https://github.com/Calvinking2/SpaceInvader/assets/54987031/9f60d027-8d2d-40ad-b5f1-ac3c89edf87b" alt="Image 2" width="45%">
  <img src="https://github.com/Calvinking2/SpaceInvader/assets/54987031/51de8255-bd4d-4ab2-89b0-4fd261fe0be3" width="45%">
</div>

 **Tutorial use on game:** [Let's Make An Arcade Game Like Space Invaders!](https://www.youtube.com/playlist?list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL)

 ## About the Game Project 

This is a Space Invader game that you find in arcade machine back in the day

Fun Fact, this is the first game that i make using Youtube Tutorial

#### Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| A,D               | Standard movement |
| Left Click        | Fire              |
| ESC               | Pause             |

## Script

 - **Shield**  :
```c#
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

```
**This is a brief explanation of the Shield**

This script mainly to represent the shield gameObject that you see in game

This part indicate that if enemy shoot to the shield gameObject then shield health will decrese by 1 until health reach 0 then the shield gameObject got destroyed
```c#
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
```
This also happen if the Enemy gameObject collide with the enemy
```c#
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
```
