using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Single responsible class
//Object pool pattern
public class ObjectPool : Singleton<ObjectPool>
{
   public List<GameObject> PrefabsForPool;
   public List<GameObject> pooledObjects = new List<GameObject>();

   public GameObject GetObjectFromPool(PanelType type)
   {
        var instance = pooledObjects.FirstOrDefault(obj => obj.name == type.ToString());
        // poolda varsa
        if (instance != null)
        {
            pooledObjects.Remove(instance);
            //açık olan panellerin altında kalmaması için
            instance.transform.SetAsLastSibling();
            instance.SetActive(true);
            return instance;
        }
      
      // poolda yoksa
      var prefab = PrefabsForPool.FirstOrDefault(obj => obj.name == type.ToString());
      if (prefab != null)
      {
         var newInstace = Instantiate(prefab, Vector3.zero, Quaternion.identity, transform);
         newInstace.name = type.ToString();
         newInstace.transform.localPosition = Vector3.zero;
         
         return newInstace;
      }
      
      Debug.LogWarning("bu isimde prefab yok");
      return null;
   }

   public void PoolObject(GameObject obj)
   {
      obj.SetActive(false);
      pooledObjects.Add(obj);
   }
}