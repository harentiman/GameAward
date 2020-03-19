using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbUpCheck : MonoBehaviour
{

    public static bool isClimbUpCheck = false;
    public static float climbUpspeed;

    // Start is called before the first frame update
    void Start()
    {
        climbUpspeed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Ladder"))
        {
            isClimbUpCheck = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        isClimbUpCheck = false;
    }
}
