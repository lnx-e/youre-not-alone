using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCMessage : MonoBehaviour
{
    public TextMeshProUGUI text;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            text.text = "You need 200 coins to exit this cave";
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            text.text = "";
        }
    }


}
