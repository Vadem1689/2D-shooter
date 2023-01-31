using System.Collections;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] private int countSpaun;

    [SerializeField] private GameObject[] enemyPrefab = new GameObject[3] ;
  
    [SerializeField] private float spamDistance = 15f;


    void Start()
    {  
        StartCoroutine(EnemyGeneratio());
    }
    IEnumerator EnemyGeneratio()
    {
        
        for(int i = 0; i < countSpaun; i++)
        {
            yield return new WaitForSeconds(1.7f);

            Vector3 poss = Random.insideUnitCircle * spamDistance;
            Instantiate(enemyPrefab[Random.Range(0, 3)], poss, Quaternion.identity);
        }
    }

}
