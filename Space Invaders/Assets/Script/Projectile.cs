using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    [SerializeField] public float projectileSpeed;
    public GameObject explosionPrebab;
    public static int enemyCount = 36;
    private PointManager pointManager;
    public GameObject ExplosionSFX;

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    void Update()
    {
        transform.Translate(Vector2.up * projectileSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyCount -= 1;
            Debug.Log(enemyCount);
            GameObject Explosion = Instantiate(explosionPrebab, transform.position, Quaternion.identity);
            GameObject explosionSFX = Instantiate(ExplosionSFX, transform.position, Quaternion.identity);  
            Destroy(collision.gameObject);
            Destroy(explosionSFX,2.5f);
            pointManager.UpdateScore(20);
            Destroy(gameObject);
            Destroy(Explosion, 1f);

            if(enemyCount == 0)
            {
                pointManager.isWin = true;
                ChangeSceneLevel();
                enemyCount = 36;
            }
        }
    }
    private void ChangeSceneLevel()
    {
        Debug.Log("Test");
        int SceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneIndex + 1);
        
    }
}
