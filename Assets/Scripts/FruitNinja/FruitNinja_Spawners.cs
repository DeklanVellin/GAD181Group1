using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Spawners : MonoBehaviour
{
    public GameObject[] fruits = new GameObject[5];
   
    float spawnTimer;
    public bool canSpawn = true;

    Vector3 direction = Vector3.left;
    int speed = 7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x <= -7.5f)
        {
            direction = Vector3.right;
        }
        else if (transform.position.x >= 7.5f)
        {
                direction = Vector3.left;
        }

        if (canSpawn == true)
        {
            if (spawnTimer > 0f)
            {
                spawnTimer -= Time.deltaTime;
            }
            else if (Random.Range(0, 500) == 5)
            {
                Instantiate(fruits[Random.Range(0, fruits.Length)], transform.position, transform.rotation);
                spawnTimer = 0.5f;//Random.Range(1f, 1.5f);

            }
        }
    }
}
