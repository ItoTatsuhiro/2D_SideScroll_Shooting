using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    // プレイヤーの弾のオブジェクト
    [SerializeField]
    GameObject _playerBulletPrefab = null;



    public void OnShot(InputAction.CallbackContext context)
    {
        // 弾が未設定の時処理しない
        if(_playerBulletPrefab == null)
        {
            return;
        }
        // 入力された瞬間以外は処理しない
        if (!context.performed)
        {
            return ;
        }

        // 弾を生成
        Instantiate(_playerBulletPrefab, transform.position, Quaternion.identity);


    }
}
