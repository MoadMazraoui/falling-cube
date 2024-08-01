using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private GameObject startPanel;
    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private Button startButton;

    [SerializeField]
    private Button restartButton;

    void Awake() {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        startButton.onClick.AddListener(() =>
        {
            StartGame();
        });
        restartButton.onClick.AddListener(() =>
        {
            RestartAfterTime();
        });
    }

    void Start() {
        ShowStartPanel();
    }

    public void ShowStartPanel() {
        startPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        Time.timeScale = 0f; // Pause the game
    }

    public void StartGame() {
        startPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f; // Resume the game
    }   

    public void ShowGameOverPanel() {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }

    // public void RestartGame() {
    //     Invoke("RestartAfterTime", 1f);
    // }

    void RestartAfterTime() {
        SceneManager.LoadScene("S1");
    }
}
