using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator; // Animatorul pentru u?ã
    [SerializeField] private string openTriggerName = "Open"; // Numele trigger-ului din Animator
    [SerializeField] private string closeTriggerName = "Close"; // Numele trigger-ului din Animator

    private bool isDoorOpen = false; // Starea curentã a u?ii

    private void OnTriggerEnter(Collider other)
    {
        // Verificãm dacã player-ul intrã în zona u?ii
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Închidem u?a când player-ul iese din zonã
        if (other.CompareTag("Player"))
        {
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
        if (!isDoorOpen)
        {
            doorAnimator.SetTrigger(openTriggerName);
            isDoorOpen = true;
        }
    }

    private void CloseDoor()
    {
        if (isDoorOpen)
        {
            doorAnimator.SetTrigger(closeTriggerName);
            isDoorOpen = false;
        }
    }
}
