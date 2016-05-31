using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    BoardManager boardScript;

    private int level = 3;

	void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        boardScript = GetComponent<BoardManager>();
        InitGame();
	
	}

    private void InitGame()
    {
        boardScript.SetupScene(level);
    }
}
