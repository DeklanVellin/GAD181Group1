using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtySword : MonoBehaviour
{
    public float dateTimer = 4f;
    public int sharpCounter = 0;
    public bool winCondition;
    public SceneController gameComplete;
    private int clean = 0;


    //collison thing on sword
    void OnCollisionExit(Collision collisionData)
    {
        if (collisionData.gameObject.name == "Hand")
        {
            print("Don't touch me " + collisionData.gameObject.name);
            sharpCounter++;
            Destroy(this.gameObject);
            clean++;
        }

    }


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
        if (winCondition == true && dateTimer < 5)
        {
            //This loads the WIN scene
            //SceneManager.LoadScene(5);
            print("You've cleaned the sword!");
            GameObject.FindObjectOfType<SceneController>().WinScreen(true);
        }
        
    }
}
   
//counter how many times it swipes

   /* if (Collision == gameObject)
       {
       
        } */


