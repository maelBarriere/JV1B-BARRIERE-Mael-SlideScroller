using UnityEngine;

public class PatrollingIA : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float patrolDistance = 5f;

    private float leftBoundary;
    private float rightBoundary;
    private int direction = 1; 

    void Start()
    {
        leftBoundary = transform.position.x - patrolDistance / 2;
        rightBoundary = transform.position.x + patrolDistance / 2;
    }

    void Update()
    {
      Move();
    }

    void Move()
    {
        // Calculer la nouvelle position
        float newX = transform.position.x + moveSpeed * direction * Time.deltaTime;

        if (newX < leftBoundary || newX > rightBoundary)
        {
            direction *= -1;
        }

        transform.position = new Vector2(newX, transform.position.y);
    }
}