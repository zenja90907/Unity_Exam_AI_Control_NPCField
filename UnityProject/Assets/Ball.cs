using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("速度")]
    [Range(0, 100)]
    public int speed = 50;
    [Header("跳躍")]
    [Range(0, 300)]
    public int jump = 0;
    [Header("是否在地板上")]
    public bool IsGround=false;

    private Rigidbody r3d;

    private void Start()
    {
        r3d = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void Walk()
    {

        if (Input.GetKey(KeyCode.W))
            r3d.AddForce(new Vector3(0, 0, speed));
        if (Input.GetKey(KeyCode.S))
            r3d.AddForce(new Vector3(0, 0, -speed));
        if (Input.GetKey(KeyCode.A))
            r3d.AddForce(new Vector3(-speed, 0,0));
        if (Input.GetKey(KeyCode.D))
            r3d.AddForce(new Vector3(speed, 0,0));
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            r3d.AddForce(new Vector3(0, jump, 0));
    }
}
