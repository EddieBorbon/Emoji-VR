using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] emojis;
 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEmojis", 1, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void spawnEmojis(){
        int randomEmojiIndex = Random.Range(0, emojis.Length);

        Vector3 randomPosition = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-0.5f, 2f), 25.5f);
        Quaternion randomRotation = emojis[randomEmojiIndex].transform.rotation;
        GameObject emoji = Instantiate(emojis[randomEmojiIndex], randomPosition, randomRotation);
    }
}
