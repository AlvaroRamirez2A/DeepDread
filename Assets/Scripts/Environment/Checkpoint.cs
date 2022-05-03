using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().ChangeCheckpoint(transform.GetChild(0));
        }
    }
}
