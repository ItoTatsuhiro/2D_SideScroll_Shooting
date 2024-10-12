using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 2D�̃Q�[���I�u�W�F�N�g�p�̊��N���X
// �e��L�����N�^�[���Ɍp�����Ďg�p����
public class GameObject2D : MonoBehaviour
{


    // ���W
    [SerializeField]
    protected Vector2 _pos;
    // �傫��
    [SerializeField]
    protected Vector2 _size;
    // ����, �x���@
    [SerializeField]
    protected float _rot;

    // �I�u�W�F�N�g�̃g�����X�t�H�[��
    // �l�̃Z�b�g�p
    private Transform _transform;


    // �A�N�e�B�u��Ԃ̃t���O
    protected bool _isActive = true;


    //---------------------------------------------------------
    // �Q�b�^�[�E�Z�b�^�[

    public Vector2 Pos
    {
        get { return _pos; }

        set
        {
            _pos = value;
            _transform.position = _pos;
        }

    }


    public Vector2 Size
    {
        get { return _size; }

        set { 
            _size = value;
            _transform.localScale = _size;
        }

    }


    public float Rot
    {
        get { return _rot; }

        set
        {
            _rot = value;
            _transform.rotation = Quaternion.Euler(0, 0, _rot);
        }

    }


    public bool IsActive
    {
        get { return _isActive; }

        set
        {
            _isActive = value;
            gameObject.SetActive(_isActive);
        }
    }


    private void Awake()
    {
        // �����l�ݒ�
        _transform = transform;
        _pos = _transform.position;
        _size = _transform.localScale;
        _rot = _transform.rotation.eulerAngles.z;
    }


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // �A�N�e�B�u�łȂ��Ƃ��������Ȃ�
        if (!_isActive)
        {
            return;
        }


    }
}
