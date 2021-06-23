using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PanelType
{
    HeyPanel,
    GoodByePanel
}

public class PanelData
{
    
}

public abstract class Panel : MonoBehaviour
{
    //single responsibility
    public virtual void ShowPanel(PanelData data)
    {
        transform.gameObject.SetActive(true);
    }
    //single responsibility
    public void HidePanel()
    {
        transform.gameObject.SetActive(false);
    }

}
