using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip hitSound;

    // Called when the object enters a trigger zone
    void OnTriggerEnter(Collider other)
    {
        // If the object being hit has the "wall" tag
        if (other.gameObject.CompareTag("wall"))
        {
            // Play the hit sound and log a message to the console
            GetComponent<AudioSource>().PlayOneShot(hitSound);
        }
    }
}
