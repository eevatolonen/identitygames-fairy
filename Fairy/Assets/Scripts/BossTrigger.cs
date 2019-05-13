﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    public GameObject boss;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(boss.GetComponent<WeepingWillow>())
                boss.GetComponent<WeepingWillow>().StartBossFight();
        }
    }
}