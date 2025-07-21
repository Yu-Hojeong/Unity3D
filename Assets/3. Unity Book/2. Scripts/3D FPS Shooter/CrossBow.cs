using System.Collections;
using UnityEngine;

public class CrossBow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shootPos;
    public bool isShoot;


    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;


        bool isTargeting = Physics.Raycast(ray, out hit);
        if (isTargeting)
        {
            StartCoroutine(ShootRoutine());
        }

    }


    IEnumerator ShootRoutine()
    {
        isShoot = true;
        GameObject arrow = Instantiate(arrowPrefab);
        arrow.transform.SetPositionAndRotation(shootPos.position, Quaternion.identity);
        yield return new WaitForSeconds(3f);
        isShoot = false;
    }
}
