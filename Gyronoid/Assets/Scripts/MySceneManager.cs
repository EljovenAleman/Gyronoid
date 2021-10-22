using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    int currentLevel = 0;
    public void RestartLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(currentLevel + 1);
        currentLevel++;
    }
}
