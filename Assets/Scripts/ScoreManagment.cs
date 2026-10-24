using UnityEngine;

public class ScoreManagment : MonoBehaviour
{
    public static ScoreManagment Instance;
    public int score;

    private void Awake()
    {
        Instance = this;
    }
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Puntaje: " + score);
        GameManager.Instance.CheckScoreVictory(score);
    }
}