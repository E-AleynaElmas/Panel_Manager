using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanelButton : MonoBehaviour
{
    public void DoHidePanel()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
