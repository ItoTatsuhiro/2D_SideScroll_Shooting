using UnityEngine;


// 弾をDestroyするためのクラス
public class BulletDestroy : MonoBehaviour
{


    // 衝突判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 画面外の壁に衝突したとき弾を消す
        if(collision.gameObject.tag == "BulletDestroy")
        {
            Destroy(gameObject);
            return;
        }

        // 自身がプレイヤーの弾だった場合
        else if(gameObject.tag == "PlayerBullet")
        {
            // 敵・敵の弾に衝突した場合弾を消す
            if(collision.gameObject.tag == "Enemy" ||
               collision.gameObject.tag == "EnemyBullet")
            {
                Destroy(gameObject);
                return;
            }
        }

        // 自身が敵の弾だった場合
        else if(gameObject.tag == "EnemyBullet")
        {
            // プレイヤー・プレイヤーの弾に衝突した場合弾を消す
            if (collision.gameObject.tag == "Player" ||
               collision.gameObject.tag == "PlayerBullet")
            {
                Destroy(gameObject);
                return;
            }
        }
        // 弾の種類が正しく設定されていない場合ログを出す
        else
        {
            Debug.LogError("弾の種類が設定されていません");
            Destroy(gameObject);
        }
    }


}
