using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawnercar : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 savePosition;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxXDistance = 0.5f;

    void Start()
    {
        savePosition = this.transform.position;
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, savePosition, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
