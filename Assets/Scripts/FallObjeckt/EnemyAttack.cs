using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //PlayerHpのスクリプト
    private PlayerHp _playerHp2;

    // Start is called before the first frame update
    void Start()
    {

        //PlayerHpを取ってくる
        _playerHp2 = GameObject.Find("HpController").GetComponent<PlayerHp>();

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
            _playerHp2._getPlayerHp -= 1;
            Destroy(this.gameObject);
        }
    }
    
}
