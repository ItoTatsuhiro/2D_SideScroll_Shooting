using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 進行方向にまっすぐ移動する弾の移動用のクラス
// 別の向きに移動する際には、transform.rotationを変更してそちら向きに移動するようにする
public class NormalBulletMovement : MonoBehaviour
{
    // 移動量
    [SerializeField]
    float _moveValue = 10.0f;



    void Update()
    {
        // 右向きに移動
        transform.Translate( Vector3.right * _moveValue * Time.deltaTime );

    }



}
