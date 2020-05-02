using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey;   // 入力制限、３秒間のクールタイム
using UnityEngine.UI;

public class ChangeGravity : MonoBehaviour
{
    
    private void Start()
    {
        // 初期を下方向
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }
    void Update()
    {
        // 上方向に変更
        if (CustomInput.Interval_InputKeydown(KeyCode.W, 3))
            Physics.gravity = new Vector3(0, 15, 0);
        // 下方向に変更
        if (CustomInput.Interval_InputKeydown(KeyCode.S, 3))
            Physics.gravity = new Vector3(0, -15, 0);
    }

}
