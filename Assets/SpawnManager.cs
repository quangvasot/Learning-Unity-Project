using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    int numObjects = 12;
    public GameObject Enemy;
    public float time;
    private GameObject[] getCount;
    private bool stopSpawn = false;
    void Start()
    {
        StartCoroutine(Respawn());
    }

     void Update()
    {
    }

    IEnumerator Respawn()
    {

        while (stopSpawn ==  false)
        {
            Vector3 center = transform.position;
            for (int i = 0; i < numObjects; i++)
            {
                int a = i * Random.Range(1, 60);
                Vector3 pos = RandomCircle(center, 6.0f, a);
                Instantiate(Enemy, pos, Quaternion.identity);
            }
            getCount = GameObject.FindGameObjectsWithTag("Enemy");
            int count = getCount.Length;
            if (count >= 6)
            {
                yield return new WaitForSeconds(4);
            } else
            yield return new WaitForSeconds(time);
        }

        Vector3 RandomCircle(Vector3 center, float radius, int a)
        {
            Debug.Log(a);
            float ang = a;
            Vector3 pos;
            pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
            pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
            pos.z = center.z;
            return pos;
        }
    }
        
}
