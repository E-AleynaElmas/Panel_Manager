using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanelButton : MonoBehaviour
{
    public static event ButtonManager.CloseListener CloseDetection;

    public void DoHidePanel()
    {
        //PanelManager.Instance.Hide(transform.parent.gameObject);
        transform.parent.gameObject.SetActive(false);
        ObjectPool.Instance.PoolObject(transform.parent.gameObject);
        CloseDetection?.Invoke();
    }
}
