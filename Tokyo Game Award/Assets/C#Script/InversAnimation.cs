using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InversAnimation : MonoBehaviour
{
    //定義
    private Animator animator;
    private bool isInvers;
    private bool isReInvers;
    private bool isIdle;
    private float freezetime;


    // Start is called before the first frame update
    void Start()
    {
        //初期化
        animator = GetComponent<Animator>();
        isInvers = true;
        isReInvers = true;
        freezetime = 1.0f;

    }
    // Update is called once per frame
    void Update()
    {


        //回転
        if (Input.GetKeyDown(KeyCode.Space) && isInvers == true) {
            PlayerController.rig.constraints = RigidbodyConstraints.FreezeAll;  //全固定
            animator.SetTrigger("isInvers");                                    //アニメーション
            Invoke("Freeze", freezetime);                                       //遅延処理
            isInvers = false;
            

        }
        //再回転
        else if (Input.GetKeyDown(KeyCode.Space) && isReInvers == true) {
            PlayerController.rig.constraints = RigidbodyConstraints.FreezeAll;
            animator.SetTrigger("isReInvers");
            Invoke("Freeze", freezetime);
            isReInvers = false;
            

        }
        //通常
        else if (isInvers == false && isReInvers == false){

            
            PlayerController.rig.constraints = RigidbodyConstraints.FreezeAll;
            animator.SetTrigger("isIdle");
            Invoke("Freeze", freezetime);
            isInvers = true;
            isReInvers = true;
            

        }
        

        

    }

    //フリーズ処理
    private void Freeze()
    {
        PlayerController.rig.constraints = RigidbodyConstraints.None;           //固定解除
        PlayerController.rig.constraints = RigidbodyConstraints.FreezeRotation;
        //PlayerController.rig.constraints = RigidbodyConstraints.FreezeRotation; //回転固定

    }
}
