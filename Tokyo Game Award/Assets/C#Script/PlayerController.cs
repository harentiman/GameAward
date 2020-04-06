using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
    public static Rigidbody rb;
    float playerspeed;
    float jampsSpeed;
    public static bool isJumping;
    float Horizontal = 0f;
  
=======
    public static Rigidbody rig;
    float playerspeed;
    float jampsSpeed;
    private bool isJumping;

>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        playerspeed = 10.0f;
        isJumping = false;
        jampsSpeed = 4000.0f;
        rb = GetComponent<Rigidbody>();
        
=======
        playerspeed = 7.0f;
        isJumping = false;
        jampsSpeed = 6.0f;
        rig = GetComponent<Rigidbody>();
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00
        //rig.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        

<<<<<<< HEAD
        Horizontal = Input.GetAxis("Horizontal") * playerspeed;
       
        Vector3 direction = new Vector3(Horizontal, 0, 0);

        if (isJumping == true)
        {
            

            if (Input.GetKey(KeyCode.X)||Input.GetKeyDown("joystick button 0"))
            {
                Debug.Log("isjamping");
                rb.AddForce(transform.up * jampsSpeed);
                isJumping = false;
            }
        }
    }
    

    void FixedUpdate()
    {
        rb.velocity = new Vector3(Horizontal, 0, 0);
=======

        if (isJumping == true)
        {


            if (Input.GetKey(KeyCode.X))
            {
                rig.velocity += new Vector3(0, jampsSpeed, 0);
                isJumping = false;
                

            }
            //上
            else if (Input.GetKey(KeyCode.W))
            {

                rig.velocity = new Vector3(0, 0, playerspeed);

            }
            //左
            else if (Input.GetKey(KeyCode.A))
            {

                rig.velocity = new Vector3(-playerspeed, 0, 0);

            }
            //下
            else if (Input.GetKey(KeyCode.S))
            {

                rig.velocity = new Vector3(0, 0, -playerspeed);

            }
            //右
            else if (Input.GetKey(KeyCode.D))
            {

                rig.velocity = new Vector3(playerspeed, 0, 0);
            }

            else
            {
                rig.velocity += new Vector3(0, 0, 0);
            }
        }
        else
        {
            rig.velocity += new Vector3(0, 0, 0);

        }
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            isJumping = true;
        }
       
    }
<<<<<<< HEAD
=======

    
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00
}

