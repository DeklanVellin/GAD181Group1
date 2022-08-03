using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Fruits : MonoBehaviour
{
    float initialVelocity;

    // Start is called before the first frame update
    void Start()
    {
        initialVelocity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.up * Time.deltaTime * initialVelocity;
    }
}
