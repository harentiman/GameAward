using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject Camera;
    public string Tag;

    // Start is called before the first frame update
    void Start()
    {
        // Playerの部分はカメラが追いかけたいオブジェクトの名前をいれる
        this.Camera = GameObject.Find(Tag);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.Camera.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);
    }
}
