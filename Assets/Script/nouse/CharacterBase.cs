using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// �L�����N�^�[�̃x�[�X�ƂȂ�N���X
// �v���C���[�E�G�L�����N�^�[���Ɍp�����Ďg�p
public class CharacterBase : GameObject2D
{

    // �L�����N�^�[�̗̑�
    [SerializeField]
    protected int _hp = 1;


    // �L�����N�^�[�̍ő�̗�
    // �v���C���[��1�̑z��
    [SerializeField]
    protected int _hpMax = 1;

    // �ړ����x
    [SerializeField]
    protected float _moveSpeed = 30.0f;



    // -------------------------------------------------
    // �Q�b�^�[�E�Z�b�^�[

    public int Hp
    {
        get { return _hp; }

        set
        {
            // �l��0�����̂Ƃ�
            if(value < 0)
            {
                _hp = 0;
            }
            // �l���ő�l���傫���Ƃ�
            else if(value > _hpMax)
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


    public int HpMax
    {
        get { return _hpMax; }

        set 
        { 
            _hpMax = value;
        }

    }


    // �L���������ۂɈ�x�������s
    private void OnEnable()
    {
        // ���l�̏�����
        _hp = _hpMax;


    }



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
