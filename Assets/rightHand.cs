using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
public class rightHand : MonoBehaviour
{
    public AudioClip hitSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("emoticon"))
        {
            GetComponent<AudioSource>().PlayOneShot(hitSound);
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
            StartCoroutine(StopVibration(0.5f));
        }
    }

    IEnumerator StopVibration(float duration)
    {
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }
}
