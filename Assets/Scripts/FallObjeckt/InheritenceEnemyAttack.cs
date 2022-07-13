using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritenceEnemyAttack : FallBace
{
    public override void Activate()
    {
        _playerHpVariable._getPlayerHp -= 1;
    }
}
