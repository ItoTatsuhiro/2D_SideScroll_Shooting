using UnityEngine;


// �e��Destroy���邽�߂̃N���X
public class BulletDestroy : MonoBehaviour
{


    // �Փ˔���
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ��ʊO�̕ǂɏՓ˂����Ƃ��e������
        if(collision.gameObject.tag == "BulletDestroy")
        {
            Destroy(gameObject);
            return;
        }

        // ���g���v���C���[�̒e�������ꍇ
        else if(gameObject.tag == "PlayerBullet")
        {
            // �G�E�G�̒e�ɏՓ˂����ꍇ�e������
            if(collision.gameObject.tag == "Enemy" ||
               collision.gameObject.tag == "EnemyBullet")
            {
                Destroy(gameObject);
                return;
            }
        }

        // ���g���G�̒e�������ꍇ
        else if(gameObject.tag == "EnemyBullet")
        {
            // �v���C���[�E�v���C���[�̒e�ɏՓ˂����ꍇ�e������
            if (collision.gameObject.tag == "Player" ||
               collision.gameObject.tag == "PlayerBullet")
            {
                Destroy(gameObject);
                return;
            }
        }
        // �e�̎�ނ��������ݒ肳��Ă��Ȃ��ꍇ���O���o��
        else
        {
            Debug.LogError("�e�̎�ނ��ݒ肳��Ă��܂���");
            Destroy(gameObject);
        }
    }


}
