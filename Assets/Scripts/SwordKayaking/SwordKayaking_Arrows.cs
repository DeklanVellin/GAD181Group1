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

        // This randomly gives an arrow a direction when it spawns
        int direction = Random.Range(0, 4);
        switch (direction)
        {
            case 0:
                print("UP");
                this.transform.Rotate(0, 0, 0, Space.World);

                input = "up";
                break;
            case 1:
                print("LEFT");
                this.transform.Rotate(0, 0, 90, Space.World);

                input = "left";
                break;
            case 2:
                print("RIGHT");
                this.transform.Rotate(0, 0, -90, Space.World);

                input = "right";
                break;
            case 3:
                print("DOWN");
                this.transform.Rotate(0, 0, 180, Space.World);

                input = "down";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        // If the player hits the correct key they get a hit
        // Otherwise if it is active too long or they hit the wrong key it's counted as a miss
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
