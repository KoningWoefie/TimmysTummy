using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yes : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        ResetScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        canvas.GetComponent<GenerateOptions>().GenerateTheThingiemcJigs();
    }
}
