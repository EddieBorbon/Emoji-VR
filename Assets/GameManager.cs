using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] emojis;
    public GameObject titleScreen;
    public GameObject resumeGame;
    private bool gameRunning = false;

    public void StartGame()
    {
        if (!gameRunning)
        {
            gameRunning = true;
            InvokeRepeating("SpawnEmojis", 1, 1.0f);
            titleScreen.SetActive(false);
            resumeGame.SetActive(true);
        }
    }

    public void StopGame()
    {
        if (gameRunning)
        {
            gameRunning = false;
            titleScreen.SetActive(true);
            resumeGame.SetActive(false);
            CancelInvoke("SpawnEmojis");

            // Limpia los emojis existentes en la escena
            foreach (GameObject emoji in GameObject.FindGameObjectsWithTag("emoticon"))
            {
                Destroy(emoji);
            }
        }
    }

    void SpawnEmojis()
    {
        int randomEmojiIndex = Random.Range(0, emojis.Length);
        Vector3 randomPosition = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-0.5f, 2.5f), 25.5f);
        Quaternion randomRotation = emojis[randomEmojiIndex].transform.rotation;
        GameObject emoji = Instantiate(emojis[randomEmojiIndex], randomPosition, randomRotation);
    }
}
