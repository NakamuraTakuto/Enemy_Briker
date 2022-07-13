using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakhert : MonoBehaviour
{
    [SerializeField]EnemyHp _enemyHp = default;
    //勇者の攻撃（ボール）との当たり判定
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //当たったら消える
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        _enemyHp._getEnemyHp -= 1;
    }
}


