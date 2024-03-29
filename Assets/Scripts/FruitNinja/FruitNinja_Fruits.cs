using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Fruits : MonoBehaviour
{
    float initialVelocity;

    bool isWhole = true;

    public Transform Fruit;


    // Start is called before the first frame update
    void Start()
    {
        initialVelocity = Random.Range(7f,13f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += Vector3.up * Time.deltaTime * initialVelocity;

        if(this.transform.position.y <= -7 && this.GetComponent<CircleCollider2D>()!= null )
        {
            
            Destroy(this.gameObject);
            print("Fruit Missed");
        }

    }

    // Collision tests
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        // Only continue if colliding with player cursor
        if (collisionData.gameObject.GetComponent<FruitNinja_Sword>() != null && isWhole)
        {
            // Replace with sprite chane and remove rigidbody or otherwise prevent collisions (will need to ask rex)
            //Destroy(this.gameObject);
            isWhole = false;
            GameObject.FindObjectOfType<FruitNinja_GameManager>().success++;
            GameObject.FindObjectOfType<FruitNinja_Spawners>().canSpawn = true;
            print("Fruit Cut");
            Fruit.GetComponent<ParticleSystem>().Play();
            Destroy(this.gameObject.GetComponent<CircleCollider2D>());
            this.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }
    }
}
