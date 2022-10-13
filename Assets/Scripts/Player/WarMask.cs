using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WarMask : MaskClass
{
    [SerializeField] private string pathName = "Sprites/TempSprites/ExampleMask1@4x";

    void Start()
    {
        maskRenderer = GameObject.Find("Mask").GetComponent<SpriteRenderer>();

        GetMaskSprite(pathName);
    }
}
