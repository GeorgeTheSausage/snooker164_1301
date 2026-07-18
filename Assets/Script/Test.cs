using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int n = 1;
    private float timer = 0f;
    void Awake()
    {
        UnityEngine.Debug.Log("Awake");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        n++ ;
        if (timer >= 1f)
        {
            UnityEngine.Debug.Log(n);
            timer = 0f;
        }
    }
}
