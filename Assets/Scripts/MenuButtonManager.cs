using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
    public string mainMenuSceneName = "StartMenu";
    public string skyboxSceneName = "SkyboxProject";
    public string treeSceneName = "TreePixelArt";

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }
    public void LoadSkyboxScene()
    {
        SceneManager.LoadScene(skyboxSceneName);
    }

    public void LoadTreeScene()
    {
        SceneManager.LoadScene(treeSceneName);
    }
}
