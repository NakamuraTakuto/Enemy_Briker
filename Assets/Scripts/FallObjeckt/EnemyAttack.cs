using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //PlayerHp�̃X�N���v�g
    private PlayerHp _playerHp2;

    // Start is called before the first frame update
    void Start()
    {

        //PlayerHp������Ă���
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

    //�v���C���[�ɂ������Ƃ��ɌĂт������
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            //�Ԃ������������
            //�Ԃ������Ƃ���PlayerHp����1����
            _playerHp2._getPlayerHp -= 1;
            Destroy(this.gameObject);
        }
    }
    
}
