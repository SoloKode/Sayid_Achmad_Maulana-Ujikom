using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform spawnPointA;
    public Transform spawnPointB;
    private float timeElapsed;
    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    private IEnumerator SpawnEnemy()
    {

        timeElapsed = 0;
        while (timeElapsed < 60)
        {
            timeElapsed += Time.deltaTime;
            int randomIndex = Random.Range(0, enemy.Length - 1);
            GameObject spawnedEnemy = Instantiate(enemy[randomIndex]);
            float spawnX = Random.Range(spawnPointA.transform.position.x, spawnPointB.transform.position.x);
            spawnedEnemy.GetComponent<Transform>().position = new Vector3(spawnX, transform.position.y, transform.position.z);
            switch (randomIndex)
            {
                case 0:
                    spawnedEnemy.GetComponent<EnemyController>().hunger = 200;
                    spawnedEnemy.GetComponent<EnemyController>().speed = 5;
                    spawnedEnemy.GetComponent<EnemyController>().score = 1;
                    break;
                case 1:
                    spawnedEnemy.GetComponent<EnemyController>().hunger = 100;
                    spawnedEnemy.GetComponent<EnemyController>().speed = 6;
                    spawnedEnemy.GetComponent<EnemyController>().score = 2;
                    break;
                case 2:
                    spawnedEnemy.GetComponent<EnemyController>().hunger = 200;
                    spawnedEnemy.GetComponent<EnemyController>().speed = 6;
                    spawnedEnemy.GetComponent<EnemyController>().score = 5;
                    break;
                case 3:
                    spawnedEnemy.GetComponent<EnemyController>().hunger = 300;
                    spawnedEnemy.GetComponent<EnemyController>().speed = 5;
                    spawnedEnemy.GetComponent<EnemyController>().score = 5;
                    break;
                default:
                    break;
            }

            yield return new WaitForSeconds(2);
        }
        yield return null;
    }
}
