using UnityEngine;

public class MoveCrane : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float initTime;
    [SerializeField] private float time;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        InvokeRepeating("Move",initTime,time);
    }

    private void Move()
    {
        rb.AddForce(Vector3.forward*speed,ForceMode.Impulse);
    }
}
