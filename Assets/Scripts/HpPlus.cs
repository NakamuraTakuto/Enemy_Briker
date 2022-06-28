using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlus : MonoBehaviour
{
    //PlayerHpのスクリプト
    private PlayerHp _playerHpPlus;

    // Start is called before the first frame update
    void Start()
    {

        //PlayerHpを取ってくる
        _playerHpPlus = GameObject.Find("HpController").GetComponent<PlayerHp>();

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -15f)
        {
            Destroy(this.gameObject);
        }
    }

    //プレイヤーにあったときに呼びだされる
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            //ぶつかったら消える
            //ぶつかったときにPlayerHpから1引く
            _playerHpPlus._playerHp += 2;
            Destroy(this.gameObject);
        }
    }

}
