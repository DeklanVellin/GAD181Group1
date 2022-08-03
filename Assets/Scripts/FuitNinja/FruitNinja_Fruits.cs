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
    void FixedUpdate()
    {
        this.transform.position += Vector3.up * Time.deltaTime * initialVelocity;

        if(this.transform.position.y <= -7)
        {
            Destroy(this.gameObject);
            print("Fruit Missed");
        }
    }

    // Collision tests
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        // Only continue if colliding with player cursor
        if (collisionData.gameObject.GetComponent<FruitNinja_Sword>() != null)
        {
            // Replace with sprite chane and remove rigidbody or otherwise prevent collisions (will need to ask rex)
            Destroy(this.gameObject);
            print("Fruit Cut");
        }
    }
}
