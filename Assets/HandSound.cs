using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
public class HandSound : MonoBehaviour
{
    public AudioClip hitSound;

    // Called when the object enters a trigger zone
    void OnTriggerEnter(Collider other)
    {
        // If the object being hit has the "wall" tag
        if (other.gameObject.CompareTag("emoticon"))
        {
            // Play the hit sound and log a message to the console
            GetComponent<AudioSource>().PlayOneShot(hitSound);
                    // Verificar si el dispositivo Oculus admite vibración

        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        
        }
    }
 

}
