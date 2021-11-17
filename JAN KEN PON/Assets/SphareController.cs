using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphareController : MonoBehaviour
{
    float circlePosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float key = 0;

        if(Input.GetKey(KeyCode.RightArrow))　key =　1.0f;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1.0f;



        circlePosition += key * 0.001f;


        gameObject.transform.Translate(circlePosition,0,0);
    }

}
