using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Collider2D playerCheck;
    [SerializeField] private LayerMask playerLayers;

    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            manager.AddScore(scoreToGive);
            Destroy(gameObject);
        }
    }
}

    