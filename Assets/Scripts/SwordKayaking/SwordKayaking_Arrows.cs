using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordKayaking_Arrows : MonoBehaviour
{
    float lifeTime;
    public string input;

    // Start is called before the first frame update
    void Start()
    {
        lifeTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (Input.GetKeyDown(input))
        {
            print("Key Hit");
            Destroy(this.gameObject);
        }
        else if (Input.anyKey || lifeTime <= 0)
        {
            print("Key Missed");
            Destroy(this.gameObject);
        }
    }
}
