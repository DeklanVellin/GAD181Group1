using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour
{
    public GameObject Bar2;
    int speed = 1;
    public bool canMove = true;
    public bool isAbleToMove = false;

    // Start is called before the first frame update
    void Start()
    {
        Bar2.GetComponent<LtR2>();
    }

    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {
        if (canMove == true)
        {
            transform.Translate(dir * speed * Time.deltaTime);

            if (transform.position.x <= -8)
            {
                dir = Vector3.right;
            }
            else if (transform.position.x >= 8)
            {
                dir = Vector3.left;
            }
        }

        if (Input.GetKeyDown("space"))
        {
            if (canMove == true)
            {
                canMove = false;
                positionCheck();
            }
            /*else
            {
                canMove = true;
            }
            */
        }
    }

    public void positionCheck()
    {
        if (canMove == false)
        {
            isAbleToMove = true;
            if (transform.position.x <= 2 && transform.position.x >= -2)
            {
                print("You win!");
                
            }
            else
            {
                print("Unlucky");
            }
        }
    }
    
}
