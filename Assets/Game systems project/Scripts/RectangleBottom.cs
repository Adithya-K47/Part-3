using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleBottom : Debog
{
    public static Color color3 = new Color(1f, 0.71f, 0.76f);

    protected override void SetRectangleColor()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = color3;
    }
}
