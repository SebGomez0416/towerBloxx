using UnityEngine;

public class MoveAnchor : MonoBehaviour
{ 
    [SerializeField] private float distance;
    private void OnEnable()
    {
        DetectBlock.OnDetectBlock += Move;
    }

    private void OnDisable()
    {
        DetectBlock.OnDetectBlock -= Move;
    }

    void Move()
    {
        transform.position+= Vector3.up*distance;
    }
}
