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
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("yes");
        }
    }

    public void ResetScene()
    {
        canvas.GetComponent<GenerateOptions>().GenerateTheThingiemcJigs();
    }

    public void ButtonDoSomethingWrong()
    {
        Debug.Log("You clicked the wrong button!");
    }

    public void ButtonDoSomethingRight()
    {
        Debug.Log("You clicked the right button!");
        ResetScene();
    }
}
