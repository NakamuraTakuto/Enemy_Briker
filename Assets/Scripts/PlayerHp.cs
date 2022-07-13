using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary> Player��Hp</summary>
    [SerializeField] private float _playerHp = 5f;

    /// <summary>Player�p��Slider������Ă���</summary>
    [SerializeField] Slider _playerHpSlider;

    /// <summary>�J�v�Z����playerHp </summary>
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

    /// <summary>PlayerHP�̍ő�l</summary>
    float _playerHpMax;
 
    void Start()
    {
        _playerHpMax = _getPlayerHp;
    }

    // Update is called once per frame
    void Update()
    {
        //HP��MAX�𒴂�����MAX�ɂ��ǂ�
        if (_getPlayerHp > _playerHpMax)
        {
            _getPlayerHp = _playerHpMax;
        }


        //HP�ɍ��킹��Slider�𒲐�����
        _playerHpSlider.value = _getPlayerHp;
    }


}
