using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operator : MonoBehaviour
{
    public GameObject CardPrefab;
    public GameObject Cards;
    public GameObject EnemyCards;
    public GameObject Result;

    //画像をとりこむ
    public Sprite[] m_Sprite;

    void Start()
    {
        //Player
        dealCards(0,-250,Cards);
        dealCards(1,0,Cards);
        dealCards(2,250,Cards);

        //Enemy
        dealCards(0, -250, EnemyCards);
        dealCards(1, 0, EnemyCards);
        dealCards(2, 250, EnemyCards);
    }

    // Start is called before the first frame update
    void dealCards(int iNumber, float fPosition, GameObject objParent)
    {
        GameObject objCard = (GameObject)Instantiate(CardPrefab);
        //objCard.transform.Find("Text").GetComponent<Text>().text = iNumber.ToString();
        objCard.GetComponent<CardScript>().iCardNumber = iNumber;
        objCard.transform.SetParent(objParent.transform, false);
        objCard.transform.localPosition = new Vector3(fPosition, 0, 0);

        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = objCard.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.sprite = m_Sprite[iNumber];
    }

    public void OpenCard()
    {
        EnemyCards.GetComponent<Enemy>().EnemyCardSelect();
        Judge();
    }

    public void Judge()
    {
        int MyCardNum = Cards.GetComponent<Cards>().intCardNumber;
        int EnemyCardNum = EnemyCards.GetComponent<Enemy>().intEnemyCardNumber;

        Text txtResult = Result.GetComponent<Text>();

        //グー=0,チョキ=1,パー=2
        if ((MyCardNum - EnemyCardNum) % 3 == 0)
        {
            txtResult.text = "Draw";
        }
        else if ((MyCardNum - EnemyCardNum) % 3 == 1)
        {
            txtResult.text = "You Lose";
        }
        else
        {
            txtResult.text = "You Win";
        }

    }
}
