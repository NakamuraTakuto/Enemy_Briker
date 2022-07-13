using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerater : MonoBehaviour
{
    //一定時間でオブジェクトを生成する
    /// <summary>お邪魔ブロック</summary>
    [SerializeField] GameObject _prefabOjamaBlook = default;
    /// <summary>HP回復アイテム</summary>
    [SerializeField] GameObject _prefabHpUp = default;

    //クールタイム設定
    [SerializeField] float _coolTime = 1f;
    [SerializeField] float _coolTimehp = 10f;

    //trueの場合、開始時にまず生成する
    [SerializeField] bool m_geberateOnStart = true;

    //タイマー変数
    float _timer;
    float _timer2;


    void Start()
    {
        //最初にオブジェクトを出す
        _timer = _coolTime;

    }

    // Update is called once per frame
    void Update()
    {
        //前フレームからの経過時間を計測する
        _timer += Time.deltaTime;
        _timer2 += Time.deltaTime;

        //タイマーを超えたら生成してタイマーをリセット
        if (_timer > _coolTime)
        {
            //  Debug.Log("yobareta");
            _timer = 0; //タイマーをリセット
            Instantiate(_prefabOjamaBlook, this.transform.position, Quaternion.identity);　//オブジェクトを生成
        }
        if (_timer2 > _coolTimehp)
        {
            Debug.Log("yobareta");
            //オブジェクトを生成する
            _timer2 = 0;
            Instantiate(_prefabHpUp, this.transform.position, Quaternion.identity);
        }
    }
}
