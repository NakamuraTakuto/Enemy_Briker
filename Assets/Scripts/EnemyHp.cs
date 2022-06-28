using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int _enemyHp = 20;
    Slider _EHpSlider;
    
    void Start()
    {
        _EHpSlider = GameObject.Find("EnemyHpSlider").GetComponent < Slider > ();
    }

    // Update is called once per frame
    void Update()
    {
        //HPに合わせてSliderを調整する
        _EHpSlider.value = _enemyHp;
    }
}
