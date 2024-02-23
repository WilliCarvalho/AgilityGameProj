using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public static SceneManage instance;

    private void Awake()
    {
        if (instance != null) Destroy(this.gameObject);

        instance = this;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
