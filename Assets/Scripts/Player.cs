using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text Checkpoint;
    Vector3 RepawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Checkpoint.text = " ";
        RepawnPoint = this.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KillBox")
        {
            this.gameObject.transform.position = RepawnPoint;
        }

        if (other.tag == "Checkpoint")
        {
            RepawnPoint = this.transform.position;
            Checkpoint.text = "Checkpoint!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            Checkpoint.text = " ";
        }
    }
}
