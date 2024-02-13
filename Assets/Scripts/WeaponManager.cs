using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LoadOut
{
    public GameObject primary;
    public GameObject secondary;
}

public class WeaponManager : MonoBehaviour
{

    public List<LoadOut> Eras;

    private void OnLevelWasLoaded(int level)
    {
        foreach(LoadOut era in Eras)
        {
            era.primary.SetActive(false);
            era.secondary.SetActive(false);
        }
        LoadOut curr = Eras[level - 1];
        curr.primary.SetActive(true);
        curr.secondary.SetActive(true);
    }

}
