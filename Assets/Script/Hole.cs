using UnityEngine;

public class Hole : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball != null)
        {
            GameMananger.Instance.PlayerScore += ball.Point;
            Destroy(ball.gameObject);
        }
    }
}
