using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component instantiates a given prefab at random time intervals and random bias from its object position.
 */
public class TimeBomberScript : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    //[SerializeField]
    Vector3 velocityOfSpawnedObject;
    //[Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField]
    float minTimeBetweenSpawns = 5f;
    //[Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField]
    float maxTimeBetweenSpawns = 10f;
    //[Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] 
    float maxXDistance =8;

    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
           //newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
