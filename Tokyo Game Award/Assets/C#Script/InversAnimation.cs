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
<<<<<<< HEAD
    private float speed = 500f;
=======
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00


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

<<<<<<< HEAD
        if (PlayerController.isJumping == true)
        {
            //回転
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 1") && isInvers == true)
            {
                
                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;  //全固定
                float step = speed * Time.deltaTime;

                
                animator.SetTrigger("isInvers");                                    //アニメーション
                Invoke("Freeze", freezetime);                                       //遅延処理
                PlayerController.rb.transform.rotation = Quaternion.Euler(0, 0, 180f);
                isInvers = false;
                Debug.Log("Invers");

            }
            //再回転
            else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 1") && isReInvers == true)
            {
                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;
                animator.SetTrigger("isReInvers");
                Invoke("Freeze", freezetime);
                PlayerController.rb.transform.rotation = Quaternion.Euler(0, 0, 180f);
                isReInvers = false;
                Debug.Log("Invers");

=======

        //回転
        if (Input.GetKeyDown(KeyCode.Space) && isInvers == true) {
            PlayerController.rig.constraints = RigidbodyConstraints.FreezeAll;  //全固定
            animator.SetTrigger("isInvers");                                    //アニメーション
            Invoke("Freeze", freezetime);                                       //遅延処理
            isInvers = false;
            
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00

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

<<<<<<< HEAD
                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;
                animator.SetTrigger("isIdle");
                Invoke("Freeze", freezetime);
                isInvers = true;
                isReInvers = true;


            }
        }
=======
            
            PlayerController.rig.constraints = RigidbodyConstraints.FreezeAll;
            animator.SetTrigger("isIdle");
            Invoke("Freeze", freezetime);
            isInvers = true;
            isReInvers = true;
            

        }
        

        

>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00
    }

    //フリーズ処理
    private void Freeze()
    {
<<<<<<< HEAD
        PlayerController.rb.constraints = RigidbodyConstraints.None;           //固定解除
        PlayerController.rb.constraints = RigidbodyConstraints.FreezeRotation;
       
=======
        PlayerController.rig.constraints = RigidbodyConstraints.None;           //固定解除
        PlayerController.rig.constraints = RigidbodyConstraints.FreezeRotation;
        //PlayerController.rig.constraints = RigidbodyConstraints.FreezeRotation; //回転固定
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00

    }
}
