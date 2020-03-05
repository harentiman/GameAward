using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject GameObj;
    public Vector3 Position;
    public Vector3 Scale;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject CreateCube = Instantiate((GameObject)Resources.Load("Cube"),Position, Quaternion.identity);
        CreateCube.transform.localScale =Scale;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collider)
    {
        
    }
}
