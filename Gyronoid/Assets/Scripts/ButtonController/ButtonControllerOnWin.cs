using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControllerOnWin : MonoBehaviour
{
    
    [SerializeField] Button restartButton;
    [SerializeField] Button nextLevelButton;
    MySceneManager sceneManager;
    private void Awake()
    {
        sceneManager = FindObjectOfType<MySceneManager>();
    }
    void Start()
    {
        nextLevelButton.onClick.AddListener(sceneManager.NextLevel);
        restartButton.onClick.AddListener(CallRestartLevel);
    }

    void CallRestartLevel()
    {

        sceneManager.RestartLevel();
    }

}
