using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �L�����N�^�[�̃X�e�[�^�X
public class CharacterStatus : MonoBehaviour
{

    // hp�̍ő�l
    [SerializeField]
    private int _hpMax = 1;

    // �̗�
    // Awake��hpMax�̒l�ɏ�����
    private int _hp;


    // -------------------------------------------------
    // �Q�b�^�[�E�Z�b�^�[

    public int HpMax
    {
        get { return _hpMax; }

        set
        {
            _hpMax = value;
        }

    }


    public int Hp
    {
        get { return _hp; }

        set
        {
            // �l��0�����̂Ƃ�
            if (value < 0)
            {
                _hp = 0;
            }
            // �l���ő�l���傫���Ƃ�
            else if (value > _hpMax)
            {
                _hp = _hpMax;
            }
            // ����ȊO
            else
            {
                _hp = value;
            }

        }
    }



    private void Awake()
    {
        // ���l�̏�����
        _hp = _hpMax;
    }



}
