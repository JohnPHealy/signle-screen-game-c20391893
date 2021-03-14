using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //[SerializeField] private UnityEvent<string> addScore;
   private Vector3 startPos;
   // private int score;

    private void Start()
    {
        startPos = player.transform.position;
        //score = 0;
        //UpdateUI();
        //PauseGame();

    }

    public void RespawnPlayer()
    {
        player.transform.position = startPos;
       // score = 0;
       // UpdateUI();
    }
}