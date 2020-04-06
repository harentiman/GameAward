using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static Rigidbody rig;
   
    public static float jampSpeed;
    public static bool isJumping;
    public static float Horisontal;
    public static float Vertical;
    float PlayerSpeed;
      

    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
        rig = GetComponent<Rigidbody>();
        jampSpeed =10000.0f;
        PlayerSpeed = 15.0f;
        Vertical = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Horisontal = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector3(Horisontal*PlayerSpeed, -15);
    

        if (isJumping == true && Input.GetKey(KeyCode.X) || Input.GetKeyDown("joystick button 0"))
        {
            
            Debug.Log("jamp");
            isJumping = false;
            rig.AddForce(new Vector3(0,jampSpeed,0));
            
        }
     
    }
    void FixedUpdate()
    {
        rig.velocity = new Vector2(Horisontal*PlayerSpeed,-15);
    }
    //ステージとの当たり判定
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            isJumping = true;
           
        }

    }




}
