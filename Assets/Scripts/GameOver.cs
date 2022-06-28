using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string _mainSceneName;
    [SerializeField] string _mainSceneName2;
    PlayerHp _change;
    EnemyHp _change2;
    // Start is called before the first frame update


    private void Start()
    {
       _change = GameObject.Find("HpController").GetComponent<PlayerHp>();
       _change2 = GameObject.Find("HpController").GetComponent<EnemyHp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_change._playerHp == 0)
        {
            SceneManager.LoadScene(_mainSceneName);
        }


        if (_change2._enemyHp == 0)
        {
            SceneManager.LoadScene(_mainSceneName2);

        }
    
    }
}
