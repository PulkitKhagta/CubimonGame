using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static float x = 0.0f; // Your actual score
    public static float y = 0.0f;
    public float lastScore = 0.0f;// The additional score from the last scene
    public float lastScore1 = 0.0f;

    public Transform player;
    public Text scoreText;
    public Text highScore;

    private void Start()
    { 

        // When scene is loaded, grab highscore from previous scene
        x = PlayerPrefs.GetFloat("Highscore", 0);
        y = PlayerPrefs.GetFloat("Score", 0);
        lastScore = x;
        lastScore1 = y;
        //highScore.text = x.ToString("0");
        if (SceneManager.GetActiveScene().buildIndex == 1 )
        {
            // lastScore = 0;
            highScore.text = x.ToString("0");
            scoreText.text = y.ToString("0");
          //  highScore = scoreText; 
        }
        else
        {
            highScore.text = x.ToString("0");
            scoreText.text = y.ToString("0");
         // highScore = scoreText;
        }
        if (y > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", x);
            highScore.text = y.ToString("0");

        }
    }

    void Update()
    {

        if (player)
        {
            // Set score
           // x = player.position.z + lastScore;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                x = player.position.z;
                y = player.position.z;
            }
            else
            {
                x = player.position.z + lastScore;
                y = player.position.z + lastScore1 ;
            }
            // Update text
            scoreText.text = y.ToString("0");

            PlayerPrefs.SetFloat("Score", y);
           
        }
        /*// Save new highscore if x is greater than the last
        if (x > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", x);
            highScore.text = y.ToString("0");

        }*/

    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

}