using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordParry_Player : MonoBehaviour
{
    bool canSwing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canSwing)
        {
            canSwing = false;
            SwordParry_EventManager.RunSpace();
        }
    }

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if(collisionData.gameObject.GetComponent<SwordParry_Arrow>() != null)
        {
            SwordParry_EventManager.RunLoss();
        }
    }
}
