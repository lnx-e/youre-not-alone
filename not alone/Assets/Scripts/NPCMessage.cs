using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCMessage : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI timer;

    public GameObject openCave;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.text = "Survive and you may get to leave.";
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.text = "";
        }
    }

    public void OpenCave()
    {
        openCave.SetActive(true);
        timer.text = "Make your way to the cave";
        text.text = "Good Job! You may now leave";

    }
}
