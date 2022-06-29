using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtR3 : MonoBehaviour
{ 
    public GameObject Bar1;
    int speed = 1;
    public bool canItMove = false;
    public bool canMove = false;

// Start is called before the first frame update
void Start()
{
    Bar1.GetComponent<LeftToRight>();
}

private Vector3 dir = Vector3.left;

// Update is called once per frame
void Update()
{
    if (canItMove == true)
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
        if (canItMove == true)
        {
            canItMove = false;
            positionCheck();
        }
        /*else
        {
            canItMove = true;
        }
        */
    }
}

public void positionCheck()
{
    if (canItMove == false)
    {
        canMove = true;
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
