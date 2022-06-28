using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public float _playerHp = 5f;
    Slider _PhpSlider;
    GameOver _scene;
    float _pHpM;
    public bool _pToF = false;

    void Start()
    {
        _PhpSlider = GameObject.Find("PlayerHpSlider").GetComponent<Slider>();
        _scene = GameObject.Find("SceneChanger").GetComponent<GameOver>();
        _pHpM = _playerHp;
    }

    // Update is called once per frame
    void Update()
    {
        //HPÇ™0Ç»Ç¡ÇΩÇÁtrue
        if (_playerHp == 0)
        {
            _pToF = true;
        }

        //HPÇ™MAXÇí¥Ç¶ÇΩÇÁMAXÇ…Ç‡Ç«Ç∑
        if (_playerHp > _pHpM)
        {
            _playerHp = _pHpM;
        }


        //HPÇ…çáÇÌÇπÇƒSliderÇí≤êÆÇ∑ÇÈ
        _PhpSlider.value = _playerHp;
    }


}
