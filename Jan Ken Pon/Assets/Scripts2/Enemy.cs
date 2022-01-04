using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int intEnemyCardNumber;
    List<GameObject> EnemyCardlist = new List<GameObject>();

    // Start is called before the first frame update
    public void EnemyCardSelect()
    {
        foreach (Transform child in transform)
        {
            EnemyCardlist.Add(child.gameObject);
        }
        int r = Random.Range(0, EnemyCardlist.Count);
        EnemyCardlist[r].transform.localPosition = new Vector3(0, -400, 0);
        //intEnemyCardNumber = int.Parse(EnemyCardlist[r].transform.Find("Text").GetComponent<Text>().text);
        intEnemyCardNumber = EnemyCardlist[r].GetComponent<CardScript>().iCardNumber;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
