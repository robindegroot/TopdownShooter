using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Projectile projectile;
    public Rocket rocket;
    public Transform muzzle;
    public float bulletSpeed;
    public float rocketSpeed;
    public float fireRateM = 0.1F;
    public float fireRateR = 1F;
    private float nextFire = 0.0F;

    void Update()
    {
        if (Input.GetButton("Fire1.1")&& Time.time > nextFire)
        {
            nextFire = Time.time + fireRateM;
            ShootM ();
        }
        if (Input.GetButton("Fire1.2")&& Time.time > nextFire)
        {
            nextFire = Time.time + fireRateR;
            ShootR();
        }
    }

    private void ShootM()
    {
        Projectile newProjectile = Instantiate (
            projectile,
            muzzle.position,
            muzzle.rotation) as Projectile;
        newProjectile.SetSpeed(bulletSpeed);
        }
    private void ShootR()
    {
        Rocket newRocket = Instantiate (
            rocket,
            muzzle.position,
            muzzle.rotation) as Rocket;
        newRocket.SetSpeed(rocketSpeed);
    }
    }