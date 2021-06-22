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

public class Panel : MonoBehaviour
{
    public void ShowPanel()
    {
        transform.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        transform.gameObject.SetActive(false);
    }

}
