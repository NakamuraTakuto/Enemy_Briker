using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerater : MonoBehaviour
{
    //��莞�ԂŃI�u�W�F�N�g�𐶐�����
    /// <summary>���ז��u���b�N</summary>
    [SerializeField] GameObject _prefabOjamaBlook = default;
    /// <summary>HP�񕜃A�C�e��</summary>
    [SerializeField] GameObject _prefabHpUp = default;

    //�N�[���^�C���ݒ�
    [SerializeField] float _coolTime = 1f;
    [SerializeField] float _coolTimehp = 10f;

    //true�̏ꍇ�A�J�n���ɂ܂���������
    [SerializeField] bool m_geberateOnStart = true;

    //�^�C�}�[�ϐ�
    float _timer;
    float _timer2;


    void Start()
    {
        //�ŏ��ɃI�u�W�F�N�g���o��
        _timer = _coolTime;

    }

    // Update is called once per frame
    void Update()
    {
        //�O�t���[������̌o�ߎ��Ԃ��v������
        _timer += Time.deltaTime;
        _timer2 += Time.deltaTime;

        //�^�C�}�[�𒴂����琶�����ă^�C�}�[�����Z�b�g
        if (_timer > _coolTime)
        {
            //  Debug.Log("yobareta");
            _timer = 0; //�^�C�}�[�����Z�b�g
            Instantiate(_prefabOjamaBlook, this.transform.position, Quaternion.identity);�@//�I�u�W�F�N�g�𐶐�
        }
        if (_timer2 > _coolTimehp)
        {
            Debug.Log("yobareta");
            //�I�u�W�F�N�g�𐶐�����
            _timer2 = 0;
            Instantiate(_prefabHpUp, this.transform.position, Quaternion.identity);
        }
    }
}
