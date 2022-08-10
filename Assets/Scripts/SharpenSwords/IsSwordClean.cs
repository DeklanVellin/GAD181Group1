using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSwordClean : MonoBehaviour
{
    public float dateTimer = 4f;
    public bool winCondition;
    public SceneController gameComplete;
    public int clean = 0;
		//Bandit - Trying to get controller to work, setting up an array for the dirt pieces so they can interact with the rest of the code
	//public GameObject[] myDirt;


	/*void Start()
	{
		List<Vector3> dirtPositions = new List<Vector3> {myDirt[0].transform.position, myDirt[1].transform.position, myDirt[2].transform.position};
	}*/
	
    void Update()
    {
        dateTimer -= Time.deltaTime;

        if (dateTimer <= 0)
        {
            gameComplete.WinScreen(false);
        }

        if (clean == 3)
        {
            winCondition = true;
            WinLoss();
        }

    }

    void WinLoss()
    {
        //if (winCondition == true && dateTimer < 5)
        //print("You've cleaned the sword!");

        GameObject.FindObjectOfType<SceneController>().WinScreen(true);
        

    }
}
