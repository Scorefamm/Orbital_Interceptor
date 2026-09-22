using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public TextMeshProUGUI scoreText;
    public int playerScore = 0;
    private int playerHealth;
    private void OnEnable()
    {
        Debug.Log("Game started");
    }
    private void OnDisable()
    {
        Debug.Log("Game ended");
    }
    private void Awake()
    {
        //THIS ASKS: Does this instance already exist, and is NOT this specific sript?
        //if so, we destroy the imposter GameObject immidietly.
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void AddScore(int points)
    {
        playerScore += points;
        UpdateScore();
        Debug.Log("Point added");
    }
    public void RemoveScore(int points)
    {
        playerScore -= points;
        UpdateScore();
        Debug.Log("Point removed");
    }

    private void UpdateScore()
    {
       scoreText.text = "Score: " + playerScore;
    }
}