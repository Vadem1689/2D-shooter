using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public static float score;
    
    void Update()
    {
        scoreText.text = score.ToString();
        
    }
}
