using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingscript : MonoBehaviour
{
    public GameObject[] build;
    public float scaleDur = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BuildBuildings());
    }


    IEnumerator BuildBuildings()
    {
        foreach (GameObject buildings in build)
        {
            yield return StartCoroutine(Build(buildings));
        }
    }

    IEnumerator Build(GameObject build2)
    {
        float constructionTime = 0f;

        while (constructionTime < scaleDur)
        {
            float time = constructionTime / scaleDur;
            build2.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, time);
            yield return null;
        }
        build2.transform.localScale = Vector3.one;
    }

}
