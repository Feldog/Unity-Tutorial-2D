using System.Collections;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTransform;
    public Transform turretHead;

    public GameObject bulletPrefab;
    public Transform muzzle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(ShootBullet());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetSet = new Vector3(targetTransform.position.x, 
            targetTransform.position.y + turretHead.localPosition.y, 
            targetTransform.position.z);

        turretHead.LookAt(targetSet);
    }

    IEnumerator ShootBullet()
    {
        while (true) 
        {
            Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);

            yield return new WaitForSeconds(1f);
        }
    }
}
