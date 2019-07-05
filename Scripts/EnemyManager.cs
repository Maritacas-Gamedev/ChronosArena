﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject myHand;
    public GameObject prefabCard;
    public bool enemyCreated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverseer.GO.cardsReceivedCount > 0 && enemyCreated == false)
        {
            CreateEnemy();
            enemyCreated = true;
        }
    }

    private void CreateCard(int i)
    {
        GameObject card = Instantiate(prefabCard, new Vector3(-557f, 288.1f), Quaternion.identity);
        card.transform.parent = myHand.transform;
        card.GetComponent<EnemyCardInHand>().deckManager = card.transform.parent.GetComponent<DeckManager>();
        card.GetComponent<EnemyCardInHand>().cardIndex = i;
        card.GetComponent<EnemyCardInHand>().thisCard = GameOverseer.GO.cardsReceived[i];
    }


    void CreateEnemy()
    {
        Debug.Log("Creating enemy");

        // Creating Cards

        for (int i = 0; i < GameOverseer.GO.cardsReceivedCount; i++) {
            CreateCard(i);
        }

    }
}
