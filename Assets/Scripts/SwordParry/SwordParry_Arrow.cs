using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordParry_Arrow : MonoBehaviour
{
    float speed;

    void OnEnable()
    {
        SwordParry_EventManager.OnSpace += CheckPosition;

        SwordParry_EventManager.OnHit += DestroyArrow;
    }

    void OnDisable()
    {
        SwordParry_EventManager.OnSpace -= CheckPosition;

        SwordParry_EventManager.OnHit -= DestroyArrow;
    }

    // Determine random speed for arrow
    void Start()
    {
        speed = Random.Range(-10f, -15.1f);
    }

    // Update is called once per frame
    void Update()
    {
        // Move arrow towards the player at the chosen speed
        this.transform.position += Vector3.right * Time.deltaTime * speed;
    }

    // Check the position of the arrow and begin either win or loss events
    void CheckPosition()
    {
        if(this.transform.position.x > -1.9f && this.transform.position.x < -0.6f)
        {
            // Calls the win event if the player succsefully parries
            SwordParry_EventManager.RunHit();
        }
        else
        {
            print("Wrong time");
        }
    }

    void DestroyArrow()
    {
        Destroy(this.gameObject);
    }
}
