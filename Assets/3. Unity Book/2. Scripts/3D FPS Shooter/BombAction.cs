using UnityEngine;

public class BombAction : MonoBehaviour
{

    public GameObject bombEffect;
    void OnCollisionEnter(Collision collision)
    {

        GameObject eff = Instantiate(bombEffect);
        eff.transform.position = transform.position;
        Destroy(gameObject);
    }
}
