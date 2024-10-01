using UnityEngine;

public class TransformPositionModified : MonoBehaviour
{    
    void Start()
    {
        Rigidbody rigid_body = GetComponent<Rigidbody>();
        Vector3 next_position = transform.position + Vector3.right * 5;

        //modify transform.position and restore
        transform.position = transform.position + Vector3.up;
        transform.position = transform.position - Vector3.up;

        rigid_body.MovePosition(next_position);

    }
}
