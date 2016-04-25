using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public float _speed;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destroyable"
            || tag == "Player")
        {
            Destroy(gameObject);
        }
        else
            Destroy(gameObject, 3F);
        if (other.tag == "enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else
            Destroy(gameObject, 3F);
    }

    void Update()
    {
        transform.Translate (Vector3.forward * _speed * Time.deltaTime);
    }

    public void SetSpeed(float value)
    {
        _speed = value;
    }
}
