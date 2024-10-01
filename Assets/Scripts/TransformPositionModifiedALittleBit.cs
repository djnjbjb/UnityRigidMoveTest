using UnityEngine;

public class TransformPositionModifiedALittleBit: MonoBehaviour
{

    void Start()
    {
        Rigidbody rigid_body = GetComponent<Rigidbody>();
        Vector3 next_position = transform.position + Vector3.right * 5;

        //modify transform.position a little bit
        //diff = 1e-7 stops moving, diff = 1e-8 not stops moving.
        float diff = (float)1e-7;
        transform.position = transform.position + transform.position * diff;

        rigid_body.MovePosition(next_position);

    }
}
