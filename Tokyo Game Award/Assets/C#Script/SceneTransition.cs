using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:Tokyo Game Award/Assets/C#Script/Pressuresensitivity.cs
public class Pressuresensitivity : MonoBehaviour
=======
public class SceneTransition : MonoBehaviour
>>>>>>> 571d8a25555ab87b341efa2466df27a2a7f6af00:Tokyo Game Award/Assets/C#Script/SceneTransition.cs
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT!!");
        }
    }
}
