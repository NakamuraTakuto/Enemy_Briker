using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakhert : MonoBehaviour
{
    EnemyHp _eHp;
    PlayerHp _pHp;
    // Start is called before the first frame update
    void Start()
    {
        _eHp = GameObject.Find("HpController").GetComponent<EnemyHp>();
        _pHp = GameObject.Find("HpController").GetComponent<PlayerHp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�E�҂̍U���i�{�[���j�Ƃ̓����蔻��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        { 
         //���������������
         Destroy(this.gameObject, 0.2f);
        }
    }
    private void OnDestroy()
    {
        _eHp._enemyHp -= 1;
    }
}


