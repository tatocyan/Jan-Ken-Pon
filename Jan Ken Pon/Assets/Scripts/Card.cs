using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{

    public UnityAction ClickAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickThis()
    {
        Debug.Log(gameObject.name + "‚ª‰Ÿ‚³‚ê‚½‚æ");
    }

}
