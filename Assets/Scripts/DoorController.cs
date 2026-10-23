using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(2f, 0f, 0f);
    public float speed = 2f;

    private Vector3 closedPosition;
    private Vector3 openPosition;

    private bool isOpen;
    private bool isMoving;

    private void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + openOffset;
    }

    public void ToggleDoor()
    {
        if (isMoving) return;

        if (isOpen)
        {
            StartCoroutine(MoveDoor(closedPosition));
        }
        else
        {
            StartCoroutine(MoveDoor(openPosition));
        }
        isOpen = !isOpen;
    }

    private IEnumerator MoveDoor(Vector3 targetPosition)
    {
        isMoving = true;

        Vector3 startPosition = transform.position;
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime * speed;

            transform.position = Vector3.Lerp(
                startPosition,
                targetPosition,
                t);

            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false;
    }
}