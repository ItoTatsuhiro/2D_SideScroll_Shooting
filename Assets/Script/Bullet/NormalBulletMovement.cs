using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �i�s�����ɂ܂������ړ�����e�̈ړ��p�̃N���X
// �ʂ̌����Ɉړ�����ۂɂ́Atransform.rotation��ύX���Ă���������Ɉړ�����悤�ɂ���
public class NormalBulletMovement : MonoBehaviour
{
    // �ړ���
    [SerializeField]
    float _moveValue = 10.0f;



    void Update()
    {
        // �E�����Ɉړ�
        transform.Translate( Vector3.right * _moveValue * Time.deltaTime );

    }



}
