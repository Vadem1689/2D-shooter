using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOwer : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private GameObject losePanel;
    [SerializeField]  public GameObject winPanel;
    

    private void Update()
    {
        if (player.health<=0)
        {
            StartCoroutine("LostGame");
        }
        if (Score.score==500)
        {
            StartCoroutine("WinGame");
        }
    }
    IEnumerator LostGame()
    {
        losePanel.SetActive(true);

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);

    }
    IEnumerator  WinGame()
    {
        winPanel.SetActive(true);

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
