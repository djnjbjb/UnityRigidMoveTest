using UnityEngine;

public class TransformPositionAssignedSameValue : MonoBehaviour
{   
    void Start()
    {
        Rigidbody rigid_body = GetComponent<Rigidbody>();
        Vector3 next_position = transform.position + Vector3.right * 5;

        //assigne same value
        transform.position = transform.position;

        rigid_body.MovePosition(next_position);

    }
}
