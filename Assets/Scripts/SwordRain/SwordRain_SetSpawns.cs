using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_SetSpawns : MonoBehaviour
{
    public GameObject swordPrefab;
    float setTimer = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setTimer -= Time.deltaTime;

        if (setTimer <= 0)
        {
            Instantiate(swordPrefab, transform.position, transform.rotation);
            setTimer = 1f;
        }
    }
}
