	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRandomiser : MonoBehaviour
{
    static List<int> LevelsToPlay = new List<int> { 1, 2, 3, 4, 5, 8, 9, 10, 11, 15};
    public int sceneRandomiser;

    void Start()
    {
        //This is the delay to ensure the win/lost screens stay on screen for more than a single frame
        StartCoroutine(winScreenDelay());
    }
    public IEnumerator winScreenDelay()
    {
        //This is what actually makes it delay for 2 seconds
        yield return new WaitForSeconds(2f);
        //Uses the List<> from above to Random.Range choose between each game listed LevelsToPlay is the list and .Count is how many there are
        int nextLevelIndex = Random.Range(0, LevelsToPlay.Count);
        int nextLevel = LevelsToPlay[nextLevelIndex];
        //This is SUPPOSED to remove the current level played from the available list
        LevelsToPlay.Remove(nextLevel);
        //Loads the next scene that was chosen from the before code
        //SceneManager.LoadScene(nextLevel);
        print("WINS "+ PlayerPrefs.GetInt("WinTotal"));
        SceneManager.LoadScene(nextLevel);
    }
}
