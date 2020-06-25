using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInteract : MonoBehaviour
{

    public GameObject currentInterObj = null;
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;



    

    private void Update()
    {
        if (Input.GetButtonDown("eOverRide") && currentInterObj) //Check to see if the object is to be stored in inventory.
        {
            if (currentInterObjScript.inventory)
            {
                inventory.AddItem(currentInterObj);
            }
            if (currentInterObjScript.openable)
            {
                if (currentInterObjScript.locked)
                {
                    if(inventory.FindItem(currentInterObjScript.itemNeeded))
                    {
                        currentInterObjScript.locked = false;
                        Debug.Log(currentInterObj.name + "was unlocked");
                        //make treasure chest disapear

                    }
                    else
                    {
                        Debug.Log(currentInterObj.name + "was not unlocked");
                    }
                }
                else
                {
                    Debug.Log(currentInterObj.name + " is unlocked");
                }
            }           
        }
    }


    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        if (otherCollision.CompareTag("InterObjectTag"))
        {
            Debug.Log(otherCollision.name);
            currentInterObj = otherCollision.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollision)
    {

        if (otherCollision.CompareTag("InterObjectTag"))
        {
            if (otherCollision.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }        
        }
    }

   

}
