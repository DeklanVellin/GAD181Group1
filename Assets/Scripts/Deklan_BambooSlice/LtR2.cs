using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtR2 : MonoBehaviour
{
    public GameObject Bar3;
    int speed = 1;
    public bool isAbleToMove = false;
    public bool canItMove = false;

    // Start is called before the first frame update
    void Start()
    {
        Bar3.GetComponent<LtR3>();
    }

    private Vector3 dir = Vector3.left;

    // Update is called once per frame
    void Update()
    {
        if (isAbleToMove == true)
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
            if (isAbleToMove == true)
            {
                isAbleToMove = false;
                positionCheck();
            }
            /*else
            {
                isAbleToMove = true;
            }
            */
        }
    }

    public void positionCheck()
    {
        if (isAbleToMove == false)
        {
            canItMove = true;
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
