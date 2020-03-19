using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbDownCheck : MonoBehaviour
{

    public static bool isClimbDownCheck = false;
    public static float climbDownspeed;

    // Start is called before the first frame update
    void Start()
    {
        climbDownspeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Ladder"))
        {
            isClimbDownCheck = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        isClimbDownCheck = false;
    }
}
