using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
  
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public Score sc ;

   
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
 public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            sc.lastScore = 0;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                sc.lastScore1 -= 25;
                sc.lastScore -= 25;
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                sc.lastScore1 -= 75;
                sc.lastScore -= 75;
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                sc.lastScore1 -= 125;
                sc.lastScore -= 125;
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                sc.lastScore1 -= 275;
                sc.lastScore -= 275;
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                sc.lastScore1 -= 325;
                sc.lastScore -= 325;
            }
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                sc.lastScore1 -= 375;
                sc.lastScore -= 375;
            }
            if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                sc.lastScore1 -= 425;
                sc.lastScore -= 425;
            }
            if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                sc.lastScore1 -= 475;
                sc.lastScore -= 475;
            }
            if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                sc.lastScore1 -= 525;
                sc.lastScore -= 525;
            }
            Invoke("Restart", restartDelay);
        }
     
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        
    }
   
}
