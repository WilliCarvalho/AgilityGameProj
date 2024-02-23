using UnityEngine;

public class StartArea : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        print("Starting timer");
        Timer.isTimerEnable = true;
    }
}
