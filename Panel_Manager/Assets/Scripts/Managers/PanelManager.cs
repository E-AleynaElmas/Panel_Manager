using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//singleton pattern for panel manager
public class PanelManager : Singleton<PanelManager>
{
    [SerializeField]
    GameObject panelParent;

    //Show whit panel type and panel data
    public void Show(PanelType type, PanelData data)
    {
        var instance = ObjectPool.Instance.GetObjectFromPool(type);
        instance.GetComponent<Panel>().ShowPanel(data);
    }

    public void Hide(GameObject obj)
    {
        ObjectPool.Instance.PoolObject(obj);
    }

}