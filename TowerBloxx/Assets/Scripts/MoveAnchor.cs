using UnityEngine;

public class MoveAnchor : MonoBehaviour
{ 
    [SerializeField] private Transform offSet;    
    private float lerpValue;
    private bool isMove;
    private Vector3 initPos;
    private Rigidbody rb;

   
    void Awake()
    {
        initPos=transform.position;
        rb= GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        DetectBlock.OnDetectBlock += StartMove;
    }

    private void OnDisable()
    {
        DetectBlock.OnDetectBlock -= StartMove;
    }  

       void Update()
    {        
        if(!isMove) return;
        Move();        
    }  
    

    void StartMove()
    {
      isMove=true;      
    }

    void Move()
    {
         if(lerpValue <= 1)
        {   Debug.Log(initPos.y);
            lerpValue+= Time.deltaTime;            
            rb.MovePosition(Vector3.Lerp(initPos, offSet.position ,lerpValue));                      
        }
        else
        {
            isMove=false;
            lerpValue=0;
        }        
        
    }
}
