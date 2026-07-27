using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    private int speed = 20;
    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        if (transform.position.y >= 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            ScoreSystem score = Object.FindAnyObjectByType<ScoreSystem>();
            score.DieEnemy();        
            Destroy(gameObject);
        }
    }
}
