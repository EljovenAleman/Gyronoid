using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillButton : MonoBehaviour
{
    [SerializeField] Button button;
    BallReposition reposition;

    private void Start()
    {
        reposition = FindObjectOfType<BallReposition>();
        button.onClick.AddListener(reposition.RepositionBall);
    }
}
