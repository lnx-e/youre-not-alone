using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCMessage : MonoBehaviour
{
    public GameObject text;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
            text.GetComponent<Text>().text = "You need 200 coins to exit this cave";
            Debug.Log("yo");
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(false);
            text.GetComponent<Text>().text = "";
        }
    }


}
