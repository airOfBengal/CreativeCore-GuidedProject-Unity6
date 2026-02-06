using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] PatrollingPoints;

    public float moveSpeed = 2f;

    private int currentPointIndex = 0;
    private Transform currentTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTarget = PatrollingPoints[currentPointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTarget != null)
        {
            // Move towards the current target
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, moveSpeed * Time.deltaTime);

            // Check if the enemy has reached the target
            if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
            {
                // Move to the next patrolling point
                currentPointIndex = (currentPointIndex + 1) % PatrollingPoints.Length;
                currentTarget = PatrollingPoints[currentPointIndex];

                transform.rotation = Quaternion.LookRotation(currentTarget.position - transform.position);
            }
        }
    }
}
