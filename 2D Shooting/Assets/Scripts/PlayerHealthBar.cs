using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public PlayerController player;
    [SerializeField] private Image bar;

    private float maxHealt;
    private float nowHealth;

    void Start()
    {
        maxHealt = player.health;
    }

    void Update()
    {
        nowHealth = player.health;
        bar.fillAmount = nowHealth/maxHealt;
    }
}
