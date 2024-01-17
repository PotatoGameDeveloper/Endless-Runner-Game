using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;

    }
}
