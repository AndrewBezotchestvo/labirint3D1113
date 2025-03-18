using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed;

    private Vector3 movement;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        _rb.AddForce(movement * _speed * Time.deltaTime);
    }

}
