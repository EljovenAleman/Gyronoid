using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Renderer blockRenderer;
    BlockHealth blockHealth;
    [SerializeField] List<Texture> textureList;
    

    private void Start()
    {
        blockHealth = GetComponent<BlockHealth>();
        blockRenderer = GetComponent<Renderer>();
        ChangeColor();
    }


    private void OnCollisionEnter(Collision collision)
    {
        ChangeColor();
    }


    public void ChangeColor()
    {
        
        Debug.Log("color should Change");
        //blockRenderer.material.color = Color.white;
        blockRenderer.material.SetTexture("_MainTex", textureList[blockHealth.health]);
        //blockRenderer.material.SetColor("_MainTex", new Color(248, 60, 1));
    }
}
