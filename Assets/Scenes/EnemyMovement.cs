using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f; 
    private Transform target; 

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize(); 

            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
