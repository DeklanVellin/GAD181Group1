using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordKayaking_GameManager : MonoBehaviour
{
    float spawnTimer = 0.5f;

    public GameObject arrowPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // This just spawns arrows at a large enough delay they don't overlap their existance
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Instantiate(arrowPrefab, this.transform.position, Quaternion.identity);
            spawnTimer = 1.1f;
        }
    }
}
