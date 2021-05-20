using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public AssetReferenceGameObject pumpkin;
    void Start()
    {
        StartCoroutine(StartSpawing());
    }

    IEnumerator StartSpawing()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));
        pumpkin.InstantiateAsync (spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
        StartCoroutine(StartSpawing());
    }
}