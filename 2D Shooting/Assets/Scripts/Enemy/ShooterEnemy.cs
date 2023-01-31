using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterEnemy : Enemy
{
    public float distance;
    private float timeNow;
    [SerializeField] float timer = 1f;

    private void Update()
    {

        timeNow += Time.deltaTime;

         distance = Vector3.Distance(transform.position, player.transform.position);
        Movement();
        if (distance <= 4.5&& timeNow>=timer)
        {
           EnemyShoot();   
           timeNow = 0;
        }
    }

    public override void EnemyShoot()
    {
            isRunning = false;  
            player.health -= damage;
    }
}

