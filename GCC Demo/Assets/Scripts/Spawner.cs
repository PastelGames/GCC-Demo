using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float maxHeight;
    public float minHeight;
    public float timeBetweenSpawns;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(timeBetweenSpawns);

        Instantiate(objectToSpawn,
            new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0f),
            Quaternion.identity);

        StartCoroutine(SpawnRoutine());
    }
}
