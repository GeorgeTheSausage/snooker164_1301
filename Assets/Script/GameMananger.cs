using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMananger : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private GameObject[] ballPosition;

    [SerializeField]
    private GameObject ballPrefab;

    [SerializeField]
    private GameObject cueBall;
    [SerializeField]
    private float xInput = 0f;

    public static GameMananger Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
    }

    // Update is called once per frame
    void Update()
    {
        RotateBall();
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            xInput = -0.1f;
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightAltKey.isPressed)
            xInput = 0.1f;
        else
            xInput = 0f;
    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj =Instantiate(ballPrefab,
                    ballPosition[i].transform.position,
                    Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }

    private void ShootBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 20, ForceMode.Impulse);
    }

    private void RotateBall()
    {
        if (cueBall != null)
            cueBall.transform.Rotate(new Vector3(0f,xInput,0f));
    }
}
