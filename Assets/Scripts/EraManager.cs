using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EraManager : MonoBehaviour
{

    public enum Era
    {
        Dino,
        StoneAge,
        WitchCraft,
        WorldWar,
        Covid
    }

    [HideInInspector]
    public Era currEra;

    private void OnLevelWasLoaded(int level)
    {
        switch (level)
        {
            case 1:
                currEra = Era.Dino;
                break;
            case 2:
                currEra = Era.StoneAge;
                break;
            case 3:
                currEra = Era.WitchCraft;
                break;
            case 4:
                currEra = Era.WorldWar;
                break;
            case 5:
                currEra = Era.Covid;
                break;
        }
    }
}
