using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public Text titleText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake() {
        Pause();
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        scoreText.enabled = false;

    }

    public void Play(){
        score = 0;
        scoreText.text =score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        scoreText.enabled = true;
        titleText.enabled = false;

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver(){
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore(){
        score++;
        scoreText.text = score.ToString();
    }
}
