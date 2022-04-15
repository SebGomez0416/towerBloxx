using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
   [SerializeField] private Transform spawnPoint;
   [SerializeField] private GameObject prefabBlock;
   private GameObject block;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.A))
          Spawn();
      if (Input.GetKeyDown(KeyCode.Space))
         Disengage();
      
   }

   void Spawn()
   {
       block =Instantiate(prefabBlock,spawnPoint.position,spawnPoint.rotation , spawnPoint);
   }

   void Disengage()
   {
       block.transform.parent = null;
       block.AddComponent<Rigidbody>();
   }


}
