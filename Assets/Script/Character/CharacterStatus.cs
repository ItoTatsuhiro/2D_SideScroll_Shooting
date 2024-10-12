using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キャラクターのステータス
public class CharacterStatus : MonoBehaviour
{

    // hpの最大値
    [SerializeField]
    private int _hpMax = 1;

    // 体力
    // AwakeでhpMaxの値に初期化
    private int _hp;


    // -------------------------------------------------
    // ゲッター・セッター

    public int HpMax
    {
        get { return _hpMax; }

        set
        {
            _hpMax = value;
        }

    }


    public int Hp
    {
        get { return _hp; }

        set
        {
            // 値が0未満のとき
            if (value < 0)
            {
                _hp = 0;
            }
            // 値が最大値より大きいとき
            else if (value > _hpMax)
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



    private void Awake()
    {
        // 数値の初期化
        _hp = _hpMax;
    }



}
