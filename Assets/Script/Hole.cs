using UnityEngine;

public class Hole : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball != null)
        {
            if (ball.Point == 0)
            {
                GameMananger.Instance.ShowString("White ball dropped\nYou Lose");
                Time.timeScale = 0f;
            }
            else
            {
                GameMananger.Instance.ShowScoreText(ball.Point);
            }
            Destroy(ball.gameObject);
        }
    }
}
