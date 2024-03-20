using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class JumpToScenes : MonoBehaviour
{
    public void Scene0()
    {
        StartCoroutine(LoadScene0());
        Debug.Log("JumpToScenes.cs: Scene0 is loading asynchroniously");
    }

    IEnumerator LoadScene0()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("0_Scene"); // The Application loads the Scene in the background as the current Scene runs.

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void Scene1()
    {
        StartCoroutine(LoadScene1());
        Debug.Log("JumpToScenes.cs: Stage1 is loading asynchroniously");
    }
    
    IEnumerator LoadScene1()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("1_Scene"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void Scene2()
    {
        StartCoroutine(LoadScene2());
        Debug.Log("JumpToScenes.cs: Stage2 is loading asynchroniously");
    }
    
    IEnumerator LoadScene2()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("2_Scene"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void Scene3()
    {
        StartCoroutine(LoadScene3());
        Debug.Log("JumpToScenes.cs: Stage2 is loading asynchroniously");
    }
    
    IEnumerator LoadScene3()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("3_Scene"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    }
