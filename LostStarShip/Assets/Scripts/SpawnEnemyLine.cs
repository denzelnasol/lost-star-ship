using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyLine : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(timeBeforeSpawning);

        while (true)
        {
            if (currentNumberOfEnemies <= 0)
            {
                for (int i = 0; i < enemiesPerWave; i++)
                {

                    Vector3 spawnPosition = new Vector3(-5, Random.Range(startPos.transform., 0);
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, -180f);

                    Instantiate(enemy, spawnPosition, spawnRotation);
                    currentNumberOfEnemies++;

                    yield return new WaitForSeconds(timeBetweenEnemies);
                }
            }
            yield return new WaitForSeconds(timeBeforeWaves);
        }
    }
}
