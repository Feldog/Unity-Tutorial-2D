using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    private Rigidbody rb;

    public float moveSpeed = 5f;
    public float moveX;
    public float moveY;

    private Vector3 dir;
    private Vector3 normalDir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        transform.LookAt(rb.position + dir);
    }

    void FixedUpdate()
    {
        dir = new Vector3(moveX, 0, moveY);
        normalDir = dir.normalized;

        rb.MovePosition(rb.position + normalDir * moveSpeed * Time.fixedDeltaTime);
    }
}
