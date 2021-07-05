using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private UnityEvent interacted;

    //private Collider2D myCollider;

    private void Start()
    {
      
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            PlayerMovement.JumpBoost = true;
        }
    }
}
