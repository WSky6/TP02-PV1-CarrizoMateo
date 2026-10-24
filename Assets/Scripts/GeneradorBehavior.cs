using UnityEngine;

public class GeneradorBehavior : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float TimeStart;
    [SerializeField] private float GenerationTime;
    void Start()
    {
        InvokeRepeating("GenerateEnemy", TimeStart, GenerationTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}