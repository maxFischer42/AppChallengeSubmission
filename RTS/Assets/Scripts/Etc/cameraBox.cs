using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBox : MonoBehaviour
{

    public Texture marqueeGraphics;

    private Vector2 marqueeOrigin;
    private Vector2 marqueeSize;

    public Rect marqueeRect;

    private void OnGUI()
    {
        marqueeRect = new Rect(marqueeOrigin.x, marqueeOrigin.y, marqueeSize.x, marqueeSize.y);
        GUI.color = new Color(0, 0, 0, .3f);
        GUI.DrawTexture(marqueeRect, marqueeGraphics);

    }
}
