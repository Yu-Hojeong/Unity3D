using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 5;

    public GameObject explosionFactory;
    
    void OnEnable()
    {
        int ranValue = UnityEngine.Random.Range(0, 10);

        if (ranValue < 7) // 70%
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // 플레이어를 바라보는 방향 값
            dir.Normalize();
        }
        else // 70%
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        ScoreManager.Instance.Score++;
        
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        if (other.gameObject.name.Contains("Bullet"))
        {
            // PlayerFire player = GameObject.Find("Player").GetComponent<PlayerFire>();
            // PlayerFire.Instance.bulletObjectPool.Add(other.gameObject);
            PlayerFire.Instance.bulletObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject); // 플레이어 오브젝트
        }

        gameObject.SetActive(false);
    }
}

// using System;
// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     private Vector3 dir;
//     public float speed = 5;

//     public GameObject explosionFactory;
    
//     void Start()
//     {
//         int ranValue = UnityEngine.Random.Range(0, 10);

//         if (ranValue < 3) // 30%
//         {
//             GameObject target = GameObject.Find("Player");
//             dir = target.transform.position - transform.position; // 플레이어를 바라보는 방향 값
//             dir.Normalize();
//         }
//         else // 70%
//         {
//             dir = Vector3.down;
//         }
//     }

//     void Update()
//     {
//         transform.position += dir * speed * Time.deltaTime;
//     }
    
//     private void OnCollisionEnter(Collision other)
//     {
//         // 점수 증가
//         GameObject smObject = GameObject.Find("ScoreManager");
//         ScoreManager sm = smObject.GetComponent<ScoreManager>();

//         // sm.SetScore(sm.GetScore() + 1); // 책에 적힌 거
//         var score = sm.GetScore() + 1;
//         sm.SetScore(score);
        
//         // 파티클 생성
//         GameObject explosion = Instantiate(explosionFactory);
//         explosion.transform.position = transform.position;
        
//         // 파괴 기능
//         Destroy(other.gameObject);
//         Destroy(gameObject);
//     }
// }