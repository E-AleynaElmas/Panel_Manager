using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Single responsible class
//Object pool pattern
//Resource Load For Scriptibleobject

public class ObjectPool : Singleton<ObjectPool>
{
    public List<GameObject> pooledObjects = new List<GameObject>();

    private GameObject heyPanelPrefab;
    private GameObject goodByePanelPrefab;
    private List<GameObject> panelPrefabs = new List<GameObject>();

    private void Start()
    {
        PanelPrefabsLoad();
    }

    public GameObject GetObjectFromPool(PanelType type)
    {
        var instance = pooledObjects.FirstOrDefault(obj => obj.name == type.ToString());
        // poolda varsa
        if (instance != null)
        {
            pooledObjects.Remove(instance);
            //açık olan panellerin altında kalmaması için
            instance.transform.SetAsLastSibling();
            return instance;
        }
      
        // poolda yoksa
        var prefab = panelPrefabs.FirstOrDefault(obj => obj.name == type.ToString());
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
        pooledObjects.Add(obj);
    }

    //Resource Load
    private void PanelPrefabsLoad()
    {
        if (heyPanelPrefab == null)
        {
            heyPanelPrefab = Resources.Load<GameObject>("Panels/HeyPanel");
            panelPrefabs.Add(heyPanelPrefab);
        }

        if (goodByePanelPrefab == null)
        {
            goodByePanelPrefab = Resources.Load<GameObject>("Panels/GoodByePanel");
            panelPrefabs.Add(goodByePanelPrefab);
        }
    }   
}