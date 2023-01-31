using UnityEngine;
using UnityEngine.UI;


public class HealthBarEnemy : MonoBehaviour
{
    public Image bar;
    private float maxHealth;
    private float nowHealth;

    private void Start()
    {
        maxHealth = gameObject.GetComponentInParent<Enemy>().health;
       
    }
    private void Update()
    {
        nowHealth = gameObject.GetComponentInParent<Enemy>().health;

        bar.fillAmount = nowHealth/maxHealth;
    }
}
