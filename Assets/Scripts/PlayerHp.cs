using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary> PlayerのHp</summary>
    [SerializeField] private float _playerHp = 5f;

    /// <summary>Player用のSliderを取ってくる</summary>
    [SerializeField] Slider _playerHpSlider;

    /// <summary>カプセル化playerHp </summary>
    public float _getPlayerHp
    {
        set
        {
            _playerHp = value;
        }
        get
        {
            return _playerHp;
        }
    }

    /// <summary>PlayerHPの最大値</summary>
    float _playerHpMax;
 
    void Start()
    {
        _playerHpMax = _getPlayerHp;
    }

    // Update is called once per frame
    void Update()
    {
        //HPがMAXを超えたらMAXにもどす
        if (_getPlayerHp > _playerHpMax)
        {
            _getPlayerHp = _playerHpMax;
        }


        //HPに合わせてSliderを調整する
        _playerHpSlider.value = _getPlayerHp;
    }


}
