using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PanelManager : Singleton<PanelManager>
{
    public List<Panel> panels = new List<Panel>();

    public void Show(PanelType type)
    {
        ObjectPool.Instance.GetObjectFromPool(type);
    }

    public void Hide(GameObject obj)
    {
        ObjectPool.Instance.PoolObject(obj);
    }
}