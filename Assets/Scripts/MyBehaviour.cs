using System;
using UnityEngine;

public class MyBehaviour : MonoBehaviour
{

    [SerializeField]
    private int x = 3;
    [SerializeField]
    private float y = 5.6f;
    public float pi = 3.1415f;
    [SerializeField]
    private int mySecret = 42;
    public static int myStatic = 10;
    public const int myConst = 22;
    public readonly int myReadOnly = 99;
    public int MyProperty { get { return 100; } }

    void Start()
    {
        Debug.Log("Pi: " +pi + ". MySecret: " + mySecret + ". MyStatic: " +myStatic);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pi = -4;
            mySecret = -11;
            myStatic = 13;
            Instantiate(gameObject);
        }
    }
}