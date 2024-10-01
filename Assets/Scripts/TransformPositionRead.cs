using UnityEngine;

public class TransformPositionRead : MonoBehaviour
{    
    void Start()
    {
        Rigidbody rigid_body = GetComponent<Rigidbody>();
        Vector3 next_position = transform.position + Vector3.right * 5;

        //read
        Vector3 vec3 = transform.position;

        rigid_body.MovePosition(next_position);

    }
}
