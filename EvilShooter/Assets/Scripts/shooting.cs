using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    public float bulletforce=10f;
    public List<GameObject> poollist = new List<GameObject>();
    int length = 20;
    private void Start()
    {
        createpool(bullet);
    }
    void createpool(GameObject gob)
    {
        for (int i = 0; i <= length; i++)
        {
            GameObject bulletobj = Instantiate(gob, firepoint.position, Quaternion.identity);
           
            poollist.Add(bulletobj);
        }
    }
    public void putInlist(GameObject goB)
    {
        goB.SetActive(false);
        poollist.Add(goB);
    }
    void Update()
    {
        //if (Input.touchCount == 1)
        //{
        //    shoot();
        //}
    }
    public void shoot()
    {
        //GameObject bulletobj = Instantiate(bullet, firepoint.position, firepoint.rotation);
        int n = poollist.Count - 1;
        GameObject bulletobj = poollist[n];
        poollist.RemoveAt(n);
        bulletobj.SetActive(true);
        bulletobj.transform.position = new Vector3(firepoint.transform.position.x, firepoint.transform.position.y, firepoint.transform.position.z);
       
        Rigidbody2D rb = bulletobj.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
