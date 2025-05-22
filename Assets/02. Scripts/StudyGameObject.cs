using Unity.VisualScripting;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 pos;
    public Quaternion rot;

    private GameObject obj;
    void Start()
    {
        CreateCharacter();
    }

    /// <summary>
    /// 모쿠진 캐릭터를 생성하는 함수
    /// </summary>
    public void CreateCharacter()
    {
        obj = Instantiate(prefab, pos, rot);
        obj.name = "Mokujin";

        Debug.Log(obj.transform.childCount);
    }
}
