using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    private Vector3 _direction;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal2");
        float z = Input.GetAxisRaw("Vertical2");
        _direction = new Vector3(x, 0f, z);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;

        if (plane.Raycast(ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustedheightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustedheightPoint);
        }
    }
    void FixedUpdate()
    {
        Vector3 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + velocity);
    }
}

