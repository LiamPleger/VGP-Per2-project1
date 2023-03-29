//Using statements are like import statements they bring code in from another program into your program.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    //Variables
    public GameObject pauseScreen;
    public TextMeshProUGUI livesText;
    public bool isGameActive; //bool is short for boolean
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject titleScreen;
    public bool paused;
    private int lives;
    private float spawnRate = 1.0f;
    private int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if user presses P key
        if (Input.GetKeyDown(KeyCode.P)) {
            ChangePaused();
        }
    }
    IEnumerator SpawnTarget() {
        while(isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    //This is  Method header or method signiture for UpdateScore and has the parameter scoreToAdd
    public void UpdateScore(int scoreToAdd) {
        //+= is like score = score + scoreToAdd
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void UpdateLives(int livesToChange) {
        lives += livesToChange;
        livesText.text = "Lives: " + lives;
        //tells us when to end the game if we are out of lives
        if (lives <= 0) {
            //this is a method call, we are "calling" GameOver() 
            GameOver();
        }
    }
    //this is a method with no parameter
    public void GameOver() {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty) {
        spawnRate /= difficulty;
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        UpdateLives(3);
        titleScreen.gameObject.SetActive(false);
    }

    void ChangePaused() {
        if (!paused) {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
