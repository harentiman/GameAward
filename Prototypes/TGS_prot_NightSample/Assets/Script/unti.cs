using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unti : MonoBehaviour
{
    private GameObject offVisual;
    private GameObject onVisual;
    // Start is called before the first frame update
    void Start()
    {
   
        offVisual = transform.GetChild(0).gameObject;
        onVisual = transform.GetChild(1).gameObject;
        this.gameObject.isStatic = false;
        offVisual.isStatic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.gameObject.isStatic = true;

            offVisual.SetActive(false);
            onVisual.SetActive(true);
            onVisual.isStatic = true;
        }
    }
}
