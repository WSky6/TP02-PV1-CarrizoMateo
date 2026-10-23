using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    public void Interact()
    {
        ScoreManagment.Instance.AddScore(points);

        Destroy(gameObject);
    }
}