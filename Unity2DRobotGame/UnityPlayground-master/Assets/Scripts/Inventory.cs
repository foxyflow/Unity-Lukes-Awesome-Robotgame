using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    bool itemAdded = true; //For Inventory Script below
    
    



    
    public GameObject[] inventory = new GameObject[10];

    public void AddItem(GameObject item)
    {
        //find the first item in the inventory
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + " was added");
                //Do something with the object.
                item.SendMessage("DoInteraction");
                break;
            }
        }

        //Inventory full
        if (!itemAdded)
        {
            Debug.Log("Inventory Full - Item not added");
        }
    }

    public bool FindItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                return true;
            }

        }
        return false;

    }
}
