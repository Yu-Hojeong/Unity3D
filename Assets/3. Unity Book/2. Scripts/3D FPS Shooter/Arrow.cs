using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float moveSpeed = 100f;
    public bool isMove = true;

    void Update()
    {
        if (!isMove) return;
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            transform.SetParent(other.transform);
            isMove = false;
        }
    }
}
