using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SetupHand();
    }

    void SetupHand()
    {
        for (int i = 0; i < 3; i++)
        {
            CardGenerator.instance.Spawn(i);
        }
    }

    public void SelectedCard()
    {
        Debug.Log("select");
    }

    public void SubmitCard()
    {

    }
}
