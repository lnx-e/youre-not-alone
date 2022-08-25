using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCMessage : MonoBehaviour
{
    public GameObject text;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
            text.GetComponent<Text>().text = "You need 200 coins to exit this cave";
            Debug.Log("yo");
        }
            
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(false);
            text.GetComponent<Text>().text = "";
        }
    }


}
