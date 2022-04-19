using UnityEngine;

public class StopBlock : MonoBehaviour
{
    [SerializeField] private float timeToStop;
    private void OnCollisionEnter(Collision c)
    {
        switch (c.gameObject.tag)
        {
            case "Block":
                Invoke("Stop",timeToStop);
                break;
            case "Ground":
                Destroy(gameObject, 1);
                break;
        }
    }
    private void Stop()
    {
       Destroy(GetComponent<Rigidbody>());        
    }
}
