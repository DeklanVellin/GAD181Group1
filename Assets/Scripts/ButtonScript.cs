using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public int ButtonID;
    int nextButton = 1;
    bool gameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Answer()
    {
            if(gameActive == true)
            {
                if (ButtonID == nextButton)
                {
                    this.GetComponent<Image>().color = Color.red;
                    nextButton++;
                    print("You pressed a button");
                    print("Next button is: " + nextButton);

                }
                else
                {
                    print("You lose");
                    gameActive = false;
                }

                if(nextButton >= 5)
                {
                    print("You win");
                }
            }
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
