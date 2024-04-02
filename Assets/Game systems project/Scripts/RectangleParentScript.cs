using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Debog : MonoBehaviour
{
    public static Color color1 = Color.white;
    private protected SpriteRenderer sr;

    virtual protected void SetRectangleColor()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = color1;  
    }

    static Debog()
    {
        Debug.Log("Top rectangle is light pink");
        Debug.Log("Bottom rectangle is dark pink");

    }

    private void Start()
    {
        SetRectangleColor();
    }
}
