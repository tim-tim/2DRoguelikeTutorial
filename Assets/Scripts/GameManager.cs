using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    BoardManager boardScript;

    private int level = 3;

	void Awake()
    {
        boardScript = GetComponent<BoardManager>();
        InitGame();
	
	}

    private void InitGame()
    {
        boardScript.SetupScene(level);
    }
}
