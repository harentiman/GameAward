using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Slider slider;


    float counttime;



    // Start is called before the first frame update
    void Start()
    {
        counttime=60;
        slider = GameObject.Find("Slider").GetComponent<Slider>();
       
    }

    // Update is called once per frame
    void Update()
    {
        counttime -= Time.deltaTime;
       
        if (counttime <= 0)
        {
            Debug.Log("ゲームオーバー");
        }
        slider.value = counttime;
    }
}
