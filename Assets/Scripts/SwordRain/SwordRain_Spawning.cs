using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_Spawning : MonoBehaviour
{
    public GameObject swordPrefab;
    float spawnTimer = 0.5f;

    bool canSpawn = true;

    // Start is called before the first frame update
    void OnEnable()
    {
        SwordRain_EventManager.OnDeath += StopSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            if (spawnTimer > 0f)
            {
                spawnTimer -= Time.deltaTime;
            }
            else if (Random.Range(0, 750) == 5)
            {
                Instantiate(swordPrefab, transform.position, transform.rotation);
                spawnTimer = 0.5f;
            }
        }
    }

    void StopSpawn()
    {
        canSpawn = false;
    }
}
