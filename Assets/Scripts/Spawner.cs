using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mover _prefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints = new List<SpawnPoint>();

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int timeToSpawn = 2;
        var wait = new WaitForSeconds(timeToSpawn);

        while (enabled)
        {
            int spawnPointIndex = Random.Range(0, _spawnPoints.Count);
            _spawnPoints[spawnPointIndex].Spawn();

            yield return wait;
        }
    }
}
