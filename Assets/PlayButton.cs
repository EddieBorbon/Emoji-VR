using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void StartGame(){
        Debug.Log("El Juego ha empezado");
        gameManager.StartGame();
    }

    void Update()
    {
        
    }
}
