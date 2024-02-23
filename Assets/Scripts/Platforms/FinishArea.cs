using UnityEngine;

public class FinishArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Timer.isTimerEnable = false;
        UIManager.instance.ShowWinnerText();
        PlayerBehaviour.instance.DisableInput();
    }
}
