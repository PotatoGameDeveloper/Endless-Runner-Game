using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 60;
    public bool creatingSection = false;
    public int secNum;
    public int yPos = (int) -0.75;

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, yPos, zPos), Quaternion.identity);
        zPos += 60;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
