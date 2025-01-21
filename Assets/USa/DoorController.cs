using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator; // Animatorul pentru u?�
    [SerializeField] private string openTriggerName = "Open"; // Numele trigger-ului din Animator
    [SerializeField] private string closeTriggerName = "Close"; // Numele trigger-ului din Animator

    private bool isDoorOpen = false; // Starea curent� a u?ii

    private void OnTriggerEnter(Collider other)
    {
        // Verific�m dac� player-ul intr� �n zona u?ii
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // �nchidem u?a c�nd player-ul iese din zon�
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
