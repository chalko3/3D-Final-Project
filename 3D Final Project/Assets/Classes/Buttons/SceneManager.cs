using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Level One");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Level Two");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Level Three");
    }
}
