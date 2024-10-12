using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// キャラクターのベースとなるクラス
// プレイヤー・敵キャラクター等に継承して使用
public class CharacterBase : GameObject2D
{

    // キャラクターの体力
    [SerializeField]
    protected int _hp = 1;


    // キャラクターの最大体力
    // プレイヤーは1の想定
    [SerializeField]
    protected int _hpMax = 1;

    // 移動速度
    [SerializeField]
    protected float _moveSpeed = 30.0f;



    // -------------------------------------------------
    // ゲッター・セッター

    public int Hp
    {
        get { return _hp; }

        set
        {
            // 値が0未満のとき
            if(value < 0)
            {
                _hp = 0;
            }
            // 値が最大値より大きいとき
            else if(value > _hpMax)
            {
                _hp = _hpMax;
            }
            // それ以外
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


    // 有効化した際に一度だけ実行
    private void OnEnable()
    {
        // 数値の初期化
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
