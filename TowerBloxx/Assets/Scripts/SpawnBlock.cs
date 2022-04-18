using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
   [SerializeField] private Transform spawnPoint;
   [SerializeField] private GameObject prefabBlock;
   private GameObject block;
   [SerializeField] private float timeToSpawn;
   [SerializeField] private float timeToStopBlock;
   private bool isFalling;
   private void Start()
   {
       Spawn();
   }
   private void Update()
   {
       if (!Input.GetKeyDown(KeyCode.Space) || isFalling) return;
       Disengage();
       Invoke("Spawn",timeToSpawn);
   }
   void Spawn()
   {
       isFalling = false;
       block =Instantiate(prefabBlock,spawnPoint.position,spawnPoint.rotation , spawnPoint);
   }
   void Disengage()
   {
       isFalling = true;
       block.transform.parent = null;
       block.AddComponent<Rigidbody>();
   }

}
