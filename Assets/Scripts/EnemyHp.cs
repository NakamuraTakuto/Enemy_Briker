using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHp : MonoBehaviour
{
    /// <summary>EnemyHp</summary>
    [SerializeField] private float _enemyHp = 20;

    /// <summary>enemy用のSliderを取ってくる</summary>
    [SerializeField] Slider _enemyHpSlider;
    /// <summary>カプセル化enemyHp</summary>
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
        //HPに合わせてSliderを調整する
        _enemyHpSlider.value = _getEnemyHp;
    }
}
