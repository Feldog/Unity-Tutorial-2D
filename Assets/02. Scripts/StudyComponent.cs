using devB;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public string changeName;

    void Start()
    {
        obj.name = changeName;
    }
}
