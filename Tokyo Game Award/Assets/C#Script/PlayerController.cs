using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static Rigidbody rig;
    float playerspeed;
    float jampsSpeed;
    private bool isJumping;


    // Start is called before the first frame update
    void Start()
    {
        playerspeed = 7.0f;
        isJumping = false;
        jampsSpeed = 6.0f;
        rig = GetComponent<Rigidbody>();
        //rig.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {


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
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            isJumping = true;
        }

    }

    
}
