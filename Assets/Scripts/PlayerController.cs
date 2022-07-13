using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//勇者を制御するコンポーネント
[RequireComponent(typeof(Rigidbody2D))]


public class PlayerController : MonoBehaviour
{   //勇者の移動速度
    [SerializeField] float m_speed = 5f;
    Rigidbody2D m_rd2d;
    public bool _noAt = false;
    [SerializeField] private GameObject AtPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rd2d = GetComponent<Rigidbody2D>();

    
        _noAt = true;

    }

    // Update is called once per frame
    void Update()
    {
        //水平方向の移動入力を受け取る
        float h = Input.GetAxisRaw("Horizontal");
        //入力に応じて勇者を動かす
        m_rd2d.velocity = h * Vector2.right * m_speed;

        //弾が消えたら出す
        if (_noAt) 
        {
            //Debug.Log("yobareta");
            var at = Instantiate(AtPrefab, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f), this.gameObject.transform.rotation);
            _noAt = false;

        }
    }
}
