using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

void OnTriggerEnter2D(Collider2D other)
{
   PlayerController2 controller = other.GetComponent<PlayerController2>();


   if (controller != null && controller.health< controller.maxHealth)
   {
       controller.ChangeHealth(1);
       Destroy(gameObject);
       controller.PlaySound(collectedClip);
   }
}
}
