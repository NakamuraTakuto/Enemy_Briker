using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�U���i�{�[���j���R���g���[������
[RequireComponent(typeof(Rigidbody2D))]

public class at : MonoBehaviour
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
    private Keyget _playerCs;
    PlayerHp _ph;
    PlayerHp _lc;

    // Start is called before the first frame update
    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        _playerCs = GameObject.Find("Yuusya").GetComponent<Keyget>();
        isPlayer = true;

        _ph = GameObject.Find("HpController").GetComponent<PlayerHp>();
        _lc = GameObject.Find("HpController").GetComponent<PlayerHp>();
        _sr = GetComponent<SpriteRenderer>();
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

        if (_lc._playerHp == 1)
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
            
            Destroy(this.gameObject);
        }


    }
   

    private void OnDestroy()
    {
      
        _playerCs._noAt = true;
       
        isPlayer = true;


        //�e�������Ƃ���HP�����炷
        Debug.Log(_ph);
        _ph._playerHp -= 1;


    }
}
