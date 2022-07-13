using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [Header("GameObject: Canvas")]
    public GameObject gameplayCanvas;
    public GameObject gameOverCanvas;

    [Space]

    [Header("GameObject: Prefab")]
    public GameObject player;

    [Space]

    [Header("GameObjects: TextMeshProGUI")]
    public TextMeshProUGUI PlayerScore;
    public TextMeshProUGUI GameOverPlayerScore;

    [Space]

    [Header("Variables")]
    public static bool isBirdDead = false;
    public static int playerScore;

    private void FixedUpdate()
    {
        PlayerScore.SetText(playerScore.ToString());

        // check if isBirdDead returns true
        if (isBirdDead == true)
        {
            // call the game over canvas
            OnGameOver();
        }
    }

    private void OnGameOver()
    {
        // destroy the player
        player.SetActive(false);

         // deactivate the Game UI canvas and activate game over canvas
        gameplayCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        

        // set the time scale to 0
        Time.timeScale = 0;

        // display the score
        GameOverPlayerScore.SetText(playerScore.ToString());
    }

    public void RefreshSceneOnReload()
    {
        // set the Time.timeScale value to 1
        Time.timeScale = 1;

        // activate the Game UI canvas and disable game over canvas
        gameplayCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);

        // reset each value to default
        playerScore = 0;
        isBirdDead = false;

        // reload the scene
        SceneManager.LoadScene(0);
    }
}