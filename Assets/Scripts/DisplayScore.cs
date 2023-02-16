using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "Score: " + Singleton.Instance.score;
    } 
}
