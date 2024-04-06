using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAR : Gun
{
    [SerializeField] GameObject prefabAlienShot;
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(50, 100, 2, 2, null); // version without special effect

        Instantiate(prefabAlienShot, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);

        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }
}
