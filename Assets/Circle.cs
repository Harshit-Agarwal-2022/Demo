using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag=="Player")
    Debug.Log("motherfucker you hit me watch where you're goinf dipshit");
   }
}
