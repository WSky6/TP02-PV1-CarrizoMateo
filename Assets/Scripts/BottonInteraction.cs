using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    public DoorController linkedDoor;
    public void Interact()
    {
        linkedDoor.ToggleDoor();
    }
}