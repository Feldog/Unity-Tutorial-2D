using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    public float bulletLifeTime = 5f;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, bulletLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + (transform.forward * Time.deltaTime * speed));
    }
}
