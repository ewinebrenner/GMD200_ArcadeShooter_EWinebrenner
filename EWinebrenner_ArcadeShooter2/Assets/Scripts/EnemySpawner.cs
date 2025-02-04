using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy enemyPrefab;
    Coroutine _spawnEnemiesRoutine;

    // Start is called before the first frame update
    void Start()
    {
        _spawnEnemiesRoutine = StartCoroutine(Co_SpawnEnemies(2.0f));

        StopCoroutine(_spawnEnemiesRoutine);
        StopAllCoroutines();
    }
    
    IEnumerator Co_SecondaryRoutine()
    {
        yield return new WaitForSeconds(5.0f);
    }
    IEnumerator Co_SpawnEnemies(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Enemy enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(delay / 2.0f);
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            yield return Co_SecondaryRoutine();
        }
    }
}
