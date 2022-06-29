using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_Swords : MonoBehaviour
{
    float speed = -5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.up * Time.deltaTime * speed;

        // Clear out swords if they fall past the screen
        if(this.transform.position.y <= -5f)
        {
            Destroy(this.gameObject);
        }
    }
}
