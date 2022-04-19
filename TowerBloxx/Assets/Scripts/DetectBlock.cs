using UnityEngine;

public class DetectBlock : MonoBehaviour
{
    [SerializeField] private float distanceRay;   
    public delegate void detectBlock();
    public static detectBlock OnDetectBlock;
    
    private void Update()
    {
        Debug.DrawRay(transform.position,transform.up* distanceRay, Color.red);
        
        RaycastHit[] hits;

        hits = Physics.RaycastAll(transform.position, Vector3.up, distanceRay);  

        if (hits.Length <= 3) return;
        OnDetectBlock?.Invoke();      
       
    }   
   
    
}
