using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndShoot : MonoBehaviour
{

    public GameObject BulletPrefab;
    public GameObject BulletPreview;
    int Speed = 15;
    bool ReadyToShoot;
    // Start is called before the first frame update
    void Start()
    {
        ReadyToShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && ReadyToShoot)
        {
            StartCoroutine(ShootBullet());
        }
    }

    IEnumerator ShootBullet()
    {
        ReadyToShoot = false;
        GameObject BulletClone = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Debug.Log("Bullet Ready");
        ReadyToShoot = true;
    }
}
