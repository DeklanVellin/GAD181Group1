using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordKayaking_Arrows : MonoBehaviour
{
    float lifeTime;

    public string input;
    public string controllerDirection;
    public float controllerInput;

    SwordKayaking_GameManager missCount;

    void OnEnable()
    {
        missCount = FindObjectOfType<SwordKayaking_GameManager>();
    }

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
                controllerDirection = "Vertical";
                controllerInput = 1;
                break;
            case 1:
                print("LEFT");
                this.transform.Rotate(0, 0, 90, Space.World);

                input = "left";
                controllerDirection = "Horizontal";
                controllerInput = -1;
                break;
            case 2:
                print("RIGHT");
                this.transform.Rotate(0, 0, -90, Space.World);

                input = "right";
                controllerDirection = "Horizontal";
                controllerInput = 1;
                break;
            case 3:
                print("DOWN");
                this.transform.Rotate(0, 0, 180, Space.World);

                input = "down";
                controllerDirection = "Vertical";
                controllerInput = -1;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        // If the player hits the correct key they get a hit
        // Otherwise if it is active too long or they hit the wrong key it's counted as a miss
        if (Input.GetKeyDown(input) || Input.GetAxis(controllerDirection) == controllerInput)
        {
            print("Key Hit");
            missCount.ArrowResult(true);

            Destroy(this.gameObject);
        }
        else if (Input.anyKey || lifeTime <= 0)
        {
            print("Key Missed");
            missCount.ArrowResult(false);

            Destroy(this.gameObject);
        }
    }
}
