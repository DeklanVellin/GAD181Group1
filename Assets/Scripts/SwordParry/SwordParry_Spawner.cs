using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordParry_Spawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    float spawnTime;

    bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(0.4f, 1.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime > 0)
        {
            spawnTime -= Time.deltaTime;
        }
        else if(canSpawn)
        {
            Instantiate(arrowPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
            canSpawn = false;
        }
    }
}
