using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    public static Rigidbody rig;
    public static GameObject gameobject;
    public static float playerspeed;
    private bool isJumping;
    private float jampspeed;
    private bool canClimb = false;
    // Start is called before the first frame update
    void Start()
    {
        canClimb = false;
        playerspeed = 7.0f;
        isJumping = false;
        jampspeed = 1.5f;
        gameobject = GetComponent<GameObject>();
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        //移動全般

        //ジャンプ

        if (isJumping == false)
        {
            if (Input.GetKey(KeyCode.Space))

            {

                rig.velocity += new Vector3(0, jampspeed, 0);
                isJumping = true;
               
            }
            //上
            else if (Input.GetKey(KeyCode.W)&& canClimb==false)
            {

                rig.velocity = new Vector3(0, 0, playerspeed);

            }
            //左
            else if (Input.GetKey(KeyCode.A))
            {

                rig.velocity = new Vector3(-playerspeed, 0, 0);

            }
            //下
            else if (Input.GetKey(KeyCode.S) && canClimb == false)
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
                rig.velocity = new Vector3(0, 0, 0);
            }

            if (canClimb == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    rig.velocity = new Vector3(0, 10, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    rig.velocity = new Vector3(0, -10, 0);
                }
            }


            ////梯子上り
            //if (ClimbUpCheck.isClimbUpCheck == true)
            //{
            //    if (Input.GetKey(KeyCode.W))
            //    {
            //        rig.velocity += new Vector3(0, ClimbUpCheck.climbUpspeed, 0);
            //    }
            //}
            ////梯子下り
            //if (ClimbDownCheck.isClimbDownCheck == true)
            //{
            //    if (Input.GetKey(KeyCode.S))
            //    {
            //        rig.velocity += new Vector3(0, -ClimbDownCheck.climbDownspeed, 0);
            //    }
            //}
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("stage")||collision.gameObject.CompareTag("obstacle"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("obstacle"))
        {
            rig.velocity = Vector3.zero;
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Ladder"))
        {
            canClimb = true;

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                Vector3 unti = new Vector3(0, 0, 0);
                unti.z= collider.gameObject.transform.position.z;
                unti.x = this.transform.position.x;
                unti.y = this.transform.position.y;
                this.transform.position = unti;
            }


        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Ladder"))
        {
            canClimb = false;
        }
    }
}
