using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakhert : MonoBehaviour
{
    [SerializeField]EnemyHp _enemyHp = default;
    //�E�҂̍U���i�{�[���j�Ƃ̓����蔻��
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //���������������
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        _enemyHp._getEnemyHp -= 1;
    }
}


