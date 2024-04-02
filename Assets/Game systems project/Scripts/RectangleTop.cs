using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleTop : Debog
{
    public static Color color2 = new Color(0.91f, 0.33f, 0.5f);

    protected override void SetRectangleColor()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = color2;
    }
}

