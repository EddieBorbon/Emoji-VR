using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emojiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randomSpeed = Random.Range(1.0f, 15.0f);
        GetComponent<Rigidbody>().velocity = transform.forward * randomSpeed;
    }

}
