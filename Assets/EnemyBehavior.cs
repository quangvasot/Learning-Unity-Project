using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    // Set the target of the chaser

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet1"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Bullet2"))
        {
            Destroy(this.gameObject);
        }
    }
}
