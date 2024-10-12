using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    // �v���C���[�̒e�̃I�u�W�F�N�g
    [SerializeField]
    GameObject _playerBulletPrefab = null;



    public void OnShot(InputAction.CallbackContext context)
    {
        // �e�����ݒ�̎��������Ȃ�
        if(_playerBulletPrefab == null)
        {
            return;
        }
        // ���͂��ꂽ�u�ԈȊO�͏������Ȃ�
        if (!context.performed)
        {
            return ;
        }

        // �e�𐶐�
        Instantiate(_playerBulletPrefab, transform.position, Quaternion.identity);


    }
}
