using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordKayaking_Warrior : MonoBehaviour
{
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void React(bool success)
    {
        if (success)
        {
            myAnim.SetTrigger("Success");
        }
        else
        {
            myAnim.SetTrigger("Fail");
        }
    }
}
