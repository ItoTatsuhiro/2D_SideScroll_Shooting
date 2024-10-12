using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 2Dのゲームオブジェクト用の基底クラス
// 弾やキャラクター等に継承して使用する
public class GameObject2D : MonoBehaviour
{


    // 座標
    [SerializeField]
    protected Vector2 _pos;
    // 大きさ
    [SerializeField]
    protected Vector2 _size;
    // 向き, 度数法
    [SerializeField]
    protected float _rot;

    // オブジェクトのトランスフォーム
    // 値のセット用
    private Transform _transform;


    // アクティブ状態のフラグ
    protected bool _isActive = true;


    //---------------------------------------------------------
    // ゲッター・セッター

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
        // 初期値設定
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
        // アクティブでないとき処理しない
        if (!_isActive)
        {
            return;
        }


    }
}
