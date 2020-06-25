using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{

    public bool inventory; //object can be stored in our inventory;
    public bool openable;
    public bool locked;
    public GameObject itemNeeded;





    public void DoInteraction()
    {
        gameObject.SetActive(false);
    }
}

    /*void OnCollisionEnter2D(Collision2D collision) //fail -- not sure why this is not working. Trying to make chest disappear if have key and collider with it.
    {
        if (collision.collider.name == "TreasureChestKing"   //if(collision.collider.tag("TagNameHere"))
            && locked == false && itemNeeded == false)
        {
            DoInteraction();

        }
    }
   
}
       */
