using UnityEngine;
using System.Collections;

public class PlayerStealth : MonoBehaviour
{
    public bool IsInvisible { get; private set; }
    private Coroutine invisibilityCoroutine;
    public void ActivateInvisibility(float duration)
    {
        if (invisibilityCoroutine != null)
        {
            StopCoroutine(invisibilityCoroutine);
        }
        invisibilityCoroutine = StartCoroutine(
        InvisibilityRoutine(duration));
    }

    private IEnumerator InvisibilityRoutine(float duration)
    {
        IsInvisible = true;
        Debug.Log("Invisibilidad activada");
        yield return new WaitForSeconds(duration);
        IsInvisible = false;
        Debug.Log("Invisibilidad terminada");
    }
}