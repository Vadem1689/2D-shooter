using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private float bulletForce = 20f;
    [SerializeField] private float timerShoot;
    private float timeNow;
 
    private void Update()
    {
        timeNow+= Time.deltaTime;
        if (timeNow>=timerShoot)
        {
            if (Input.GetMouseButton(0))
            {
                Shoot();
                timeNow = 0;
            }
        }
    }
    public void Shoot()
    {
        GameObject bullet= Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up*bulletForce,ForceMode2D.Impulse);
    }
}
