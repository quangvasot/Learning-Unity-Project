using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform Player;
    public GameObject Bullet1;
    public GameObject Bullet2;
    public float bulletspeed = 30f;
    void Update()   
    {
        //player stuff
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 aimPos = (mousePos - objectPos).normalized;
        float Pizangle = Mathf.Atan2(aimPos.y, aimPos.x) * Mathf.Rad2Deg;
        Player.rotation = Quaternion.Euler(0, 0, Pizangle);

        //shooting stuff
        Vector3 aimDir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float aimAngle = Mathf.Atan2(aimDir.x, aimDir.y) * Mathf.Rad2Deg;
        if (Input.GetButtonDown("Fire1"))   
        {
            GameObject bulletclone1 = Instantiate(Bullet1);
            bulletclone1.transform.position = Player.position;
            bulletclone1.transform.rotation = Quaternion.identity;
            bulletclone1.GetComponent<Rigidbody2D>().velocity = Player.right * bulletspeed ;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject bulletclone2 = Instantiate(Bullet2);
            bulletclone2.transform.position = Player.position;
            bulletclone2.transform.rotation = Quaternion.identity;
            bulletclone2.GetComponent<Rigidbody2D>().velocity = Player.right * bulletspeed;
        }
    }
}
    