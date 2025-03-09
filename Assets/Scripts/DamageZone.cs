using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageZone : MonoBehaviour
{
   void OnTriggerStay2D(Collider2D other)
   {
       PlayerController2 controller = other.GetComponent<PlayerController2>();


       if (controller != null)
       {
           controller.ChangeHealth(-1);
       }
   }
}
