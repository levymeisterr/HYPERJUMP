using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKey : Pickup
{

    private int keyID = 100;
    
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
        {
            KeyRing.AddKey(keyID);
        }
        base.DoOnPickup(collision);
        
    }
}
