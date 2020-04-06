using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyStoneControl : MonoBehaviour
{
    private Rigidbody HeavyStone;
    private GameObject HeavyStoneObj;
    private float HeavyStoneSpeed;
    public static bool hit;
    // Start is called before the first frame update
    void Start()
    {
        HeavyStone = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    //プレイヤーとの当たり判定
    private void OnTriggerStay(Collider collider)
    {
        hit = true;
        HeavyStoneSpeed = PlayerController.Horisontal*8;
       
        if (collider.gameObject.CompareTag("Player"))
        {

            if (Input.GetKey(KeyCode.B) && Input.GetKeyDown(KeyCode.D) 
                || Input.GetKey("joystick button 1") || Input.GetKey("joystick button 2") && Input.GetAxis("Horizontal") > 0)
            {


                HeavyStone.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
                PlayerController.rig.velocity = new Vector3(PlayerController.Horisontal*3.5f, 0, 0);
                HeavyStone.velocity = new Vector3(HeavyStoneSpeed, 0, 0);

            }
            else if (Input.GetKey(KeyCode.B) && Input.GetKeyDown(KeyCode.A) 
                || Input.GetKey("joystick button 1")||  Input.GetKey("joystick button 2")&& Input.GetAxis("Horizontal") < 0) 
            {
                Debug.Log("true");
                HeavyStone.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
                PlayerController.rig.velocity = new Vector3(PlayerController.Horisontal * 3.5f, 0, 0);
                HeavyStone.velocity = new Vector3(HeavyStoneSpeed, 0, 0);
            
            }

            else
            {
                HeavyStone.constraints = RigidbodyConstraints.FreezeRotation |
                                     RigidbodyConstraints.FreezePositionX |
                                     RigidbodyConstraints.FreezePositionZ;
            }
        }
    }
    


}

