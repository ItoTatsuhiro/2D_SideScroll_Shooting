using UnityEngine;
using UnityEngine.InputSystem;

// �v���C���[�̓��͂��󂯎���Ĉړ������邽�߂̃N���X
public class PlayerMovement : MonoBehaviour
{

    // �v���C���[�C���v�b�g���擾����p�̕ϐ�
    PlayerInput _playerInput;

    // �L�����N�^�[�R���g���[���[���擾����p
    CharacterController _characterController;

    // �ړ��̃x�N�g��
    Vector3 _moveVector;

    // �ړ��ʂ̒l
    [SerializeField]
    float _moveValue = 50;



    // Start is called before the first frame update
    void Start()
    {
        // playerInput���擾
        _playerInput = GetComponent<PlayerInput>();

        // �擾�ł��Ȃ������Ƃ��G���[��\��������
        if( _playerInput == null)
        {
            Debug.LogError("PlayerInput������܂���");
        }

        // �L�����N�^�[�R���g���[���[���擾
        _characterController = GetComponent<CharacterController>();

        // �擾�ł��Ȃ������Ƃ��G���[��\��
        if(_characterController == null)
        {
            Debug.LogError("CharacterController������܂���");
        }


    }

    // Update is called once per frame
    void Update()
    {
        // PlayerInput��CharacterController���擾�ł��Ȃ������Ƃ��͏������s��Ȃ�
        if (_playerInput == null || _characterController == null)
        {
            return;
        }

        // �ړ��ʂ��v�Z
        CalcMovement();
        // �ړ������s
        ExecuteMovement();

    }


    // �ړ���������E�ʂ��v�Z����֐�
    void CalcMovement()
    {

        // ���͂���Ă���������擾
        var inputVector = _playerInput.actions["Move"].ReadValue<Vector2>().normalized;

        // �ړ��̃x�N�g���ɒl���Z�b�g
        // �l�͓��͂���Ă�������Ɉړ��ʂ�deltatime���|�������̂Ƃ���
        _moveVector =
            new Vector3(inputVector.x * _moveValue * Time.deltaTime, inputVector.y * _moveValue * Time.deltaTime, 0);

    }


    // �ړ����������s����֐�
    void ExecuteMovement()
    {
        // �ړ��̃x�N�g�����ړ�������
        _characterController.Move(_moveVector);
    }


}
