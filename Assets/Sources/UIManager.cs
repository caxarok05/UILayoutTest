using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void ChangeTab(GameObject tab)
    {
        if (tab.active == true)
        {
            tab.SetActive(false);
        }
        else
        {
            tab.SetActive(true);
        }

    }


}
