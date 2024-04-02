using UnityEngine;
using TMPro;
using System.Collections;

public class TextColorChanger : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public Color[] colors;
    public float changeInterval = 1f;

    private Coroutine colorChangeCoroutine;

    void Start()
    {
     colorChangeCoroutine = StartCoroutine(ChangeTextColor());
    }

    IEnumerator ChangeTextColor()
    {
        while (true)
        {
            Color newColor = colors[Random.Range(0, colors.Length)];
            textMesh.color = newColor;
            yield return new WaitForSeconds(changeInterval);
        }
    }
}
