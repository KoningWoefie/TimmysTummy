using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yes : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private Singleton singleton = Singleton.Instance;

    // Start is called before the first frame update
    void Start()
    {
        canvas.GetComponent<GenerateOptions>().GenerateTheThingiemcJigs(singleton.EU, singleton.NL);
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
        canvas.GetComponent<GenerateOptions>().GenerateTheThingiemcJigs(singleton.EU, singleton.NL);
    }

    public void ButtonDoSomethingWrong()
    {
        Debug.Log("You clicked the wrong button!");
        GameOver();
    }

    public void ButtonDoSomethingRight()
    {
        Debug.Log("You clicked the right button!");
        singleton.score++;
        ResetScene();
    }

    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void BackToMenu()
    {
        singleton.score = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void SetEU()
    {
        singleton.EU = true;
        singleton.NL = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void SetNL()
    {
        singleton.EU = false;
        singleton.NL = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
