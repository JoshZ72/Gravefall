using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    
    private object enemy;

    private float enemyInterval = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
    }

    private IEnumerator spawnEnemy(float enemyInterval, object enemy)
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newenemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(enemyInterval, newenemy));
    }
}
