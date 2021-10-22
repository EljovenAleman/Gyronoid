using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControllerOnLose : MonoBehaviour
{
    [SerializeField] Button restartButton;
    MySceneManager sceneManager;
    private void Awake()
    {
        sceneManager = FindObjectOfType<MySceneManager>();
    }
    void Start()
    {

        restartButton.onClick.AddListener(sceneManager.RestartLevel);
    }
}
