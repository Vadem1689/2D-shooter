using UnityEngine;

public class BombEnemy : Enemy
{
    private float timeNow;
    [SerializeField] float timer = 1f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        timeNow += Time.deltaTime;

        if (timeNow >= timer)
        {
            if (collision.gameObject.tag == "Player")
            {
                EnemyShoot();
                timeNow = 0f;
            }
        }
       
    }
    public override void EnemyShoot()
    {
        player.health -= damage;
        
    }
}
