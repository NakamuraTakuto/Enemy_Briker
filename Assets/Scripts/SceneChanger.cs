using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string _mainSceneName;
    [SerializeField] string _helpScene;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(_mainSceneName);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter)) ;
    }

    public void ChangeSceneMain()
    {
        SceneManager.LoadScene(_mainSceneName);
    }
}
