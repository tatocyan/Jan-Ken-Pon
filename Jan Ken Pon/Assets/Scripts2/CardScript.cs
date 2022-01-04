using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{

    public int iCardNumber;

    public void ChoiceCard()
    {
        GameObject objCards = this.transform.parent.gameObject;
        
        if(objCards.GetComponent<Cards>().SelectCard != null)
        {
            objCards.GetComponent<Cards>().SelectCard.GetComponent<Transform>().localPosition
                = objCards.GetComponent<Cards>().InitPosition;
        }

        objCards.GetComponent<Cards>().SelectCard = this.gameObject;
        objCards.GetComponent<Cards>().InitPosition = this.transform.localPosition;
        objCards.GetComponent<Cards>().intCardNumber = iCardNumber;


        string strNum = this.transform.Find("Text").GetComponent<Text>().text;
        this.transform.localPosition = new Vector3(0, 400, 0);
    }

}
