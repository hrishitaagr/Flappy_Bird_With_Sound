using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Flappingo flappingo;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        score=0;
        scoreText.text= score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale= 1f;
        flappingo.enabled=true;

        Pipe[] pipe= FindObjectsOfType<Pipe>();

        for(int i=0; i<pipe.Length; i++){
            Destroy(pipe[i].gameObject);
        }

    }
    public void Pause()
    {
        Time.timeScale = 0f;
        flappingo.enabled= false;

    }


   public void GameOver()
   {
    gameOver.SetActive(true);
    playButton.SetActive(true);
    Pause();
   }
   public void IncreaseScore()
   {
     score++;
     scoreText.text = score.ToString();
   }
}
