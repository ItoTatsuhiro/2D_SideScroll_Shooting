using UnityEngine;
using UnityEngine.InputSystem;

// プレイヤーの入力を受け取って移動させるためのクラス
public class PlayerMovement : MonoBehaviour
{

    // プレイヤーインプットを取得する用の変数
    PlayerInput _playerInput;

    // キャラクターコントローラーを取得する用
    CharacterController _characterController;

    // 移動のベクトル
    Vector3 _moveVector;

    // 移動量の値
    [SerializeField]
    float _moveValue = 50;



    // Start is called before the first frame update
    void Start()
    {
        // playerInputを取得
        _playerInput = GetComponent<PlayerInput>();

        // 取得できなかったときエラーを表示させる
        if( _playerInput == null)
        {
            Debug.LogError("PlayerInputがありません");
        }

        // キャラクターコントローラーを取得
        _characterController = GetComponent<CharacterController>();

        // 取得できなかったときエラーを表示
        if(_characterController == null)
        {
            Debug.LogError("CharacterControllerがありません");
        }


    }

    // Update is called once per frame
    void Update()
    {
        // PlayerInputかCharacterControllerが取得できなかったときは処理を行わない
        if (_playerInput == null || _characterController == null)
        {
            return;
        }

        // 移動量を計算
        CalcMovement();
        // 移動を実行
        ExecuteMovement();

    }


    // 移動する方向・量を計算する関数
    void CalcMovement()
    {

        // 入力されている方向を取得
        var inputVector = _playerInput.actions["Move"].ReadValue<Vector2>().normalized;

        // 移動のベクトルに値をセット
        // 値は入力されている方向に移動量とdeltatimeを掛けたものとする
        _moveVector =
            new Vector3(inputVector.x * _moveValue * Time.deltaTime, inputVector.y * _moveValue * Time.deltaTime, 0);

    }


    // 移動処理を実行する関数
    void ExecuteMovement()
    {
        // 移動のベクトル分移動させる
        _characterController.Move(_moveVector);
    }


}
