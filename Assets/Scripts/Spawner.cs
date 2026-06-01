using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 3f;
    [SerializeField] float maxSpawnDelay = 8f;
    [SerializeField] Attacker attacker;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attacker, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
