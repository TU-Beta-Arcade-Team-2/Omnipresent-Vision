using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WarMask : MaskClass
{
    private void OnEnable()
    {
        maskRenderer = GameObject.Find("Mask").GetComponent<SpriteRenderer>();

        maskRenderer.sprite = m_maskSprite;
    }
}
