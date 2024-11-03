using UnityEngine;

public class MovingLight : MonoBehaviour
{
 
    public Transform movingObject;
    public Transform startPoint;
    public Transform endPoint;

    public float speed = 2f;
    int direction = 1;
    private void Update() {
        Vector3 target = CurrentMovementTarget();

        movingObject.position = Vector3.MoveTowards(movingObject.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector3)movingObject.position).magnitude;

        if (distance <= 0.1f)
        {
            direction *= -1;
        }
    }

    Vector3 CurrentMovementTarget()
    {
        if (direction == 1)
        {
            return startPoint.position;
        }
        else{
            return endPoint.position;
        }
    }
    private void OnDrawGizmos() {
        if(movingObject != null && startPoint != null && endPoint != null)
        {
            Gizmos.DrawLine(movingObject.transform.position, startPoint.position);
            Gizmos.DrawLine(movingObject.transform.position, endPoint.position);
        }
    }
}
