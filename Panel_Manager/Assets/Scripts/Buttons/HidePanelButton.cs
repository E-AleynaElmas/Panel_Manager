using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanelButton : MonoBehaviour
{
    public void DoHidePanel()
    {
        PanelManager.Instance.Hide(transform.parent.gameObject);
        ShowPanelButton.currentButton.SetActive();
    }
}
