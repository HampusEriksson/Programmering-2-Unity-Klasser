using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float repeatRate = 2f;
    private float limitX = 10;
    private float limitY = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomPosition(), enemyPrefab.transform.rotation);
    }

    Vector3 RandomPosition()
    {
        float x = Random.Range(-limitX, limitX);
        float y = Random.Range(-limitY, limitY);
        float z = 0;

        return new Vector3(x, y, z);
    }


}
