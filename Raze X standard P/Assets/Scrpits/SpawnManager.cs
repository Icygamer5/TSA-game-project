using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int spawnpointnum = 1;

    public static SpawnManager Instance;

    SpawnPoint[] spawnpoints;

    private void Awake()
    {
        Instance = this;
        spawnpoints= GetComponentsInChildren<SpawnPoint>();

    }

    public Transform GetSpawnpoint()
    {
        return spawnpoints[Random.Range(0, spawnpoints.Length)].transform;
    }
}
