using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(direction.magnitude > 1f)
        {
            direction.Normalize();
        }

        rb.linearVelocity = direction * speed;
    }   
    

}
