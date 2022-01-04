using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{

    //CardBox配列にカードオブジェクトを格納{グー、チョキ、パー}
    public GameObject[] CardBox;

    public static CardGenerator instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        //上記のfor文と同様の意味
        /*
        GameObject cardObjRock = Instantiate(cardRock);
        GameObject cardObjScissors = Instantiate(cardScissors);
        GameObject cardObjPaper = Instantiate(cardPaper);
        cardObjRock.transform.SetParent(hand.transform);
        cardObjScissors.transform.SetParent(hand.transform);
        cardObjPaper.transform.SetParent(hand.transform);
        */

    }

    public void Spawn(int number)
    {
        GameObject cardObj = Instantiate(CardBox[number]);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
