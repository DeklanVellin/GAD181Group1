using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_Player : MonoBehaviour
{
    float lowerLimit = -9.5f;
    float upperLimit = 9.5f;
    float speed = 0.025f;

    bool canMove = true;

    // Start is called before the first frame update
    void OnEnable()
    {
        SwordRain_EventManager.OnDeath += Death;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            // Only allow horizontal movement within the camera boundaries
            float curPos = Mathf.Clamp(this.transform.position.x + Input.GetAxis("Horizontal") * speed, lowerLimit, upperLimit);
            this.transform.position = new
            Vector3(curPos, this.transform.position.y, this.transform.position.z);
        }
    }

    // Collision test
    void OnCollisionEnter2D()
    {
        SwordRain_EventManager.RunDead();
    }

    void Death()
    {
        canMove = false;
    }
}
