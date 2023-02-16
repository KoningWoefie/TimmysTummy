using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public bool isRight;

    public void SetText(string text)
    {
        GetComponentInChildren<Text>().text = text;
    }
}
