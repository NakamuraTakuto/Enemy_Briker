using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�U���i�{�[���j���R���g���[������
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerAttack : MonoBehaviour
{
    private bool isPlayer;
    [SerializeField] GameObject m_player = default;
    SpriteRenderer _sr;

    //�{�[�����ŏ��ɓ�������
    [SerializeField] Vector2 m_powerDrection = Vector2.up;

    //�{�[�����ŏ��ɓ������傫��
    [SerializeField] float m_powerScare = 10f;
    Rigidbody2D m_rb2d;
    [Header("�{�[���̃I�t�Z�b�g"), SerializeField] Vector3 _ballOffset;

    //�v���C���[�̃X�N���v�g
    private PlayerController  _playerCs;
    /*[SerializeField]*/ PlayerHp _playerHp = default;
    // Start is called before the first frame update
    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        _playerCs = GameObject.Find("Yuusya").GetComponent<PlayerController >();
        isPlayer = true;
        _sr = GetComponent<SpriteRenderer>();
        _playerHp = GameObject.Find("Yuusya").GetComponent<PlayerHp>();
    }


    // Update is called once per frame
    void Update()
    {

        if (isPlayer)
        {
            //�{�[����łO�͗E�҂Ƀ{�[�������Ă���
            transform.position = new Vector3(GameObject.Find("Yuusya").transform.position.x, transform.position.y, transform.position.z);

            //�X�y�[�X�L�[�̓��͂��󂯎��A�{�[����ł��o��
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_rb2d.AddForce(m_powerDrection.normalized * m_powerScare, ForceMode2D.Impulse);
                isPlayer = false;
            }
        }

        if (_playerHp._getPlayerHp == 1)
        {
            _sr.color = Color.red;
        }
        else
        {
            _sr.color = Color.white;
        }

        //���ɗ������������
        if (this.transform.position.y < -10f)
        {
            _playerHp._getPlayerHp -= 1;
            Destroy(this.gameObject);
        }


    }
   
}
