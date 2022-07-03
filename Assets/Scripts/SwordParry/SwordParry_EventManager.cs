using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordParry_EventManager : MonoBehaviour
{
    // Called when player presses space
    // Compares position of arrow to winning zone
    // Stops player from swinging again
    public delegate void PlayerSwing();
    public static event PlayerSwing OnSpace;

    public static void RunSpace()
    {
        print("You attempted to parry the arrow");
        OnSpace();
    }

    // Called if the arrow is inside the winning area
    // Arrow is destroyed
    // Play win screen
    public delegate void ArrowHit();
    public static event ArrowHit OnHit;

    public static void RunHit()
    {
        print("Arrow parried");
        OnHit();
    }

    // Called if the arrow collides with the player
    // Play lose screen
    public delegate void PlayerLoss();
    public static event PlayerLoss OnLoss;

    public static void RunLoss()
    {
        print("Arrow missied");
        OnLoss();
    }
}
