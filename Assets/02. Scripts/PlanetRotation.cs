using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotSpeed = 30f; // 자전 속도

    public float revolutionSpeed = 10f; // 공전 속도
    public Transform rotTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime); // 자전

        transform.RotateAround(rotTarget.position, Vector3.up, revolutionSpeed * Time.deltaTime); // 공전
    }
}
