using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform enemy;
    public float timeBeforeSpawning = 1.5f;
    public float timeBetweenEnemies = 0.25f;
    public float timeBeforeWaves = 2.0f;

    public int enemiesPerWave = 4;
    private int currentNumberOfEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(timeBeforeSpawning);

        while(true)
        {
            if (currentNumberOfEnemies <= 0)
            {
                for (int i = 0; i < enemiesPerWave; i++)
                {

                    Vector3 spawnPosition = new Vector3(Random.Range(-11f, 11f), 9, 0);
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, -180f);

                    Instantiate(enemy, spawnPosition, spawnRotation);
                    currentNumberOfEnemies++;

                    yield return new WaitForSeconds(timeBetweenEnemies);
                }
            }
            yield return new WaitForSeconds(timeBeforeWaves);
        }
    }

    public void KilledEnemy()
    {
        currentNumberOfEnemies--;
    }
}
