using UnityEngine;

public class GameMananger : MonoBehaviour
{
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    public static GameMananger Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
