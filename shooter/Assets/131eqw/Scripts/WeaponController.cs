using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{

    public GameObject bullet;
    private bool canFire = true;
    public float cooldown = .4f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T) && canFire == true)
        {
            canFire = false;
            StartCoroutine("reload");


            GameObject temp = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            temp.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000);
        }

    }

    IEnumerator reload()
    {
        yield return new WaitForSeconds(cooldown);
        canFire = true;
    }
}