using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] string _mainSceneName;
    [SerializeField] string _mainSceneName2;
    [SerializeField] PlayerHp _changeGameOver;
    [SerializeField] EnemyHp _changeClear;

    // Update is called once per frame
    void Update()
    {
        if (_changeGameOver._getPlayerHp == 0)
        {
            SceneManager.LoadScene(_mainSceneName);
        }


        if (_changeClear._getEnemyHp == 0)
        {
            SceneManager.LoadScene(_mainSceneName2);

        }
    
    }
}
