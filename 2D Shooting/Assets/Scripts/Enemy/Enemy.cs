using UnityEngine;

public  abstract class Enemy : MonoBehaviour
{
    [SerializeField] private float speed ;
    public float health;
    public float damage;

    public bool isRunning=true;
 
    public PlayerController player;

    public Rigidbody2D rb;

    private void Start()
    {
        player =  GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRunning = false;
            EnemyShoot();
        }

    }
   
    private void FixedUpdate()
    {
        Movement();
    }
    public void Movement()
    {
        if (isRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
           
        }
    }
    
    public abstract void EnemyShoot();
}
