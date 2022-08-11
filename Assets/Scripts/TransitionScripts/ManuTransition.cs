using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuTransition : MonoBehaviour
{
	
	static List<int> LevelsToPlay = new List<int> { 1, 2, 3, 4, 5, 8, 9, 10, 11, 15};
	public int sceneRandomiser;
    int playerWins = 0;
    int playerLives = 3;

    // Start is called before the first frame update
    public void Play()
    {
        PlayerPrefs.SetInt("WinTotal", playerWins);
        PlayerPrefs.SetInt("CurrentLives", playerLives);
		//print("Lives:" + playerLives);


        int nextLevelIndex = Random.Range(0, LevelsToPlay.Count);
        int nextLevel = LevelsToPlay[nextLevelIndex];
        //This is SUPPOSED to remove the current level played from the available list
        LevelsToPlay.Remove(nextLevel);
        //Loads the next scene that was chosen from the before code
		SceneManager.LoadScene(nextLevel);
    }

}
