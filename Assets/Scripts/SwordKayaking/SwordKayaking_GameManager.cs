using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordKayaking_GameManager : MonoBehaviour
{
    float spawnTimer = 0.5f;
    float gameTimer = 8f;

    public GameObject arrowPrefab;

    int misses;
    SceneController gameComplete;
    SwordKayaking_Warrior myWarrior;

    // Start is called before the first frame update
    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();
        myWarrior = FindObjectOfType<SwordKayaking_Warrior>();
    }

    // Update is called once per frame
    // This just spawns arrows at a large enough delay they don't overlap their existance
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        gameTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Instantiate(arrowPrefab, this.transform.position, Quaternion.identity);
            spawnTimer = 1.1f;
        }

        if (gameTimer <= 0)
        {
            if (misses < 3)
            {
                print("YOU WIN!!!");
                gameComplete.WinScreen(true);
            }
            else
            {
                print("You Lose :(");
                gameComplete.WinScreen(false);
            }
        }
    }

    public void ArrowResult(bool success)
    {
        if (!success)
        {
            misses ++;
            myWarrior.React(false);
        }
        else
        {
            myWarrior.React(true);
        }
    }
}
