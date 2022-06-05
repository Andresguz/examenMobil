using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancias : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject enemyShot;
 


    private bool _stopSpawning = false;
    public void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }
  


    void Update()
    {

    }

    IEnumerator SpawnEnemyRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        Vector3 posToSpawn = new Vector3(Random.Range(-8.0f, 8.0f), 7.5f, 0);
        while (_stopSpawning == false)
        {
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            GameObject newEnemy1 = Instantiate(enemyShot, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            newEnemy1.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);
        }

    }

   

    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}
