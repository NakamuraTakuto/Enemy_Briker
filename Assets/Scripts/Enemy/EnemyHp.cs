using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHp : MonoBehaviour
{
    /// <summary>EnemyHp</summary>
    [SerializeField] private float _enemyHp = 20;

    /// <summary>enemy�p��Slider������Ă���</summary>
    [SerializeField] Slider _enemyHpSlider;
    /// <summary>�J�v�Z����enemyHp</summary>
    public float _getEnemyHp
    {
        set
        {
            _enemyHp = value;
        }
        get
        {
            return _enemyHp;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        //HP�ɍ��킹��Slider�𒲐�����
        _enemyHpSlider.value = _getEnemyHp;
    }
}
