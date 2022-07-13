using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�E�҂𐧌䂷��R���|�[�l���g
[RequireComponent(typeof(Rigidbody2D))]


public class PlayerController : MonoBehaviour
{   //�E�҂̈ړ����x
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
        //���������̈ړ����͂��󂯎��
        float h = Input.GetAxisRaw("Horizontal");
        //���͂ɉ����ėE�҂𓮂���
        m_rd2d.velocity = h * Vector2.right * m_speed;

        //�e����������o��
        if (_noAt) 
        {
            //Debug.Log("yobareta");
            var at = Instantiate(AtPrefab, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f), this.gameObject.transform.rotation);
            _noAt = false;

        }
    }
}
