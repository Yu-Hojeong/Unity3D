using UnityEngine;
using UnityEngine.Pool;

public class PoolManager : MonoBehaviour
{
    public ObjectPool<GameObject> pool;
    public GameObject prefab;

    void Awake()
    {
        pool = new ObjectPool<GameObject>(CreateObject,OnGetObject,OnReleaseObject,OnDestroyObject);
    }


    GameObject CreateObject()
    {
        GameObject obj = Instantiate(prefab);
        obj.SetActive(false);
        return obj;
    }

    void OnGetObject(GameObject obj)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        obj.SetActive(true);
    }
    void OnReleaseObject(GameObject obj)
    {
        obj.SetActive(false);
    }
    void OnDestroyObject(GameObject obj)
    {
        Destroy(obj);
    }
    
}
