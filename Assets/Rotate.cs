using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform Player;
    public GameObject Bullet;
    public float bulletspeed = 30f;
    void Update()   
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 aimPos = (mousePos - objectPos).normalized;

        float Pizangle = Mathf.Atan2(aimPos.y, aimPos.x) * Mathf.Rad2Deg;
        Player.rotation = Quaternion.Euler(0, 0, Pizangle -90);

        if (Input.GetButtonDown("Fire1"))   
        {
            GameObject bulletclone = Instantiate(Bullet, Player.position, Quaternion.Euler(new Vector3(0, 0, Pizangle -90)));       
            bulletclone.GetComponent<Rigidbody2D>().velocity = Player.right * bulletspeed ;
        }
    }
}
    