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
        InvokeRepeating("Impulse",initTime,time);
    }

    private void Impulse()
    {
        rb.AddForce(Vector3.forward*speed,ForceMode.Impulse);
    }

}
