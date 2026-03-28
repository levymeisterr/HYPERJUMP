using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealth : MonoBehaviour
{
    public GameObject pickUpEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Heals the player to full health when they collide with the pickup, then destroys the pickup
        if (collision.tag=="Player")
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.ReceiveHealing(playerHealth.maximumHealth);
            if (pickUpEffect!=null)
            {
                Instantiate(pickUpEffect, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
