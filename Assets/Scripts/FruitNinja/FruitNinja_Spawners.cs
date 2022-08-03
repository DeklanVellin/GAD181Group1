using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Spawners : MonoBehaviour
{
    public GameObject[] fruits = new GameObject[5];
   
    float spawnTimer = 0.5f;
    public bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn == true)
        {
            if (spawnTimer > 0f)
            {
                spawnTimer -= Time.deltaTime;
            }
            else if (Random.Range(0, 2750) == 5)
            {
                Instantiate(fruits[Random.Range(0, fruits.Length)], transform.position, transform.rotation);
                spawnTimer = 0.5f;//Random.Range(1f, 1.5f);

            }
        }
    }
}
