using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuTransition : MonoBehaviour
{
	
	static List<int> LevelsToPlay = new List<int> { 0, 1, 2, 3, 4, 5 };
	public int sceneRandomiser;
    public int playerWins;
	
    // Start is called before the first frame update
    public void Play()
    {
       
        PlayerPrefs.SetInt("WinTotal", playerWins);



        int nextLevelIndex = Random.Range(0, LevelsToPlay.Count);
        int nextLevel = LevelsToPlay[nextLevelIndex];
        //This is SUPPOSED to remove the current level played from the available list
        LevelsToPlay.Remove(nextLevel);
        //Loads the next scene that was chosen from the before code
		SceneManager.LoadScene(nextLevel);
    }

}
