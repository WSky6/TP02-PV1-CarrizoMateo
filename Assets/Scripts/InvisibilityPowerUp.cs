using UnityEngine;
using System.Collections;

public class InvisibilityPowerUp : MonoBehaviour
{
    private MeshRenderer renderer;
    private Collider powerUpCollider;
    [SerializeField] private float invisibilityDuration = 8f;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        powerUpCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStealth stealth = other.GetComponent<PlayerStealth>();
            if (stealth != null)
            {
                stealth.ActivateInvisibility(invisibilityDuration);
                StartCoroutine(RespawnPowerUp());
            }
        }
    }

    private IEnumerator RespawnPowerUp()
    {
        renderer.enabled = false;
        powerUpCollider.enabled = false;
        yield return new WaitForSeconds(20f);
        renderer.enabled = true;
        powerUpCollider.enabled = true;
    }
}