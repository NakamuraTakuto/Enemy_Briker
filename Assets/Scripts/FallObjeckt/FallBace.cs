using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FallBace : MonoBehaviour
{
    /// <summary>PlayerHp‚ðŽæ‚Á‚Ä‚­‚é</summary>
    public PlayerHp _playerHpVariable;
    public abstract void Activate();
    private void Start()
    {
        _playerHpVariable = GameObject.Find("Yuusya").GetComponent<PlayerHp>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Activate();
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (this.transform.position.y < -10 || this.transform.position.x < -4)
        {
            Destroy(this.gameObject);
        }
    }
}
