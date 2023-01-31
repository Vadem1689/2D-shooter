using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private static float damage = 30f;
    private float enemyHealth;

    private GameObject enemy;

    [SerializeField] private float prize;
  
    private void Start()
    {
        Destroy(gameObject,4f);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemy=collision.gameObject;

            GiveDamage();
        }

        Destroy(gameObject);
    }
    public void GiveDamage()
    {
        enemyHealth = enemy.GetComponent<Enemy>().health -= damage;

            if (enemyHealth <= 0)
            {
                Destroy(enemy);

                Score.score += prize;
            }
    }
}
