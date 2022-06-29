using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_EventManager : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath OnDeath;

    public static void RunDead()
    {
        OnDeath();
        print("You Died");
    }
}
