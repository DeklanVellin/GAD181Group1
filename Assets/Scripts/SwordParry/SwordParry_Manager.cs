using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordParry_Manager : MonoBehaviour
{
    SceneController gameComplete;

    void OnEnable()
    {
        SwordParry_EventManager.OnHit += WinCondition;

        SwordParry_EventManager.OnLoss += LossCondition;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WinCondition()
    {
        gameComplete.WinScreen(true);
    }

    void LossCondition()
    {
        gameComplete.WinScreen(false);
    }
}
