using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{
    [SerializeField]
    GameObject gameManager;

	// Use this for initialization
	void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
