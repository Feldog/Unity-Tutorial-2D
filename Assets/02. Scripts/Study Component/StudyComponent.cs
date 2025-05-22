using devB;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();

        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
