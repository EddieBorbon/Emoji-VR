using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.z) > 60 || Mathf.Abs(transform.position.x) > 20 || Mathf.Abs(transform.position.y) > 20)
        {
        Destroy(gameObject);
        }
    }
}
