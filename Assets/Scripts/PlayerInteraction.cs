using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance = 3f;
    public LayerMask interactableLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance, interactableLayer))
        {
            ButtonInteraction button = hit.collider.GetComponent<ButtonInteraction>();
            if (button != null)
            {
                button.Interact();
                return;
            }
            Collectible collectible = hit.collider.GetComponent<Collectible>();

            if (collectible != null)
            {
                collectible.Interact();
                return;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * interactionDistance);
    }
}