using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PickMeUP : MonoBehaviour
{
    private UIScript userInterface;
    public int pointsWorth = 1;






    private void Start()
    {
        // Find the UI in the scene and store a reference for later use
        userInterface = GameObject.FindObjectOfType<UIScript>();

    }

    //This will create a dialog window asking for which dialog to add
    private void Reset()
    {
        Utils.Collider2DDialogWindow(this.gameObject, true);
    }





    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
       
        string playerTag = otherCollider.gameObject.tag;

        if (userInterface != null)
        {
            // add one point
            int playerId = (playerTag == "Player") ? 0 : 1;
            userInterface.AddPoints(playerId, pointsWorth);
            this.gameObject.SetActive(false);


        }

        
    }


}
