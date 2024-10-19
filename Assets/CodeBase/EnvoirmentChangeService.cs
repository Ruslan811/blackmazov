using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class EnvoirmentChangeService : MonoBehaviour
{
    [SerializeField] private NPCService[] _allNPC;
    [SerializeField] private Material _nightMat;
    [SerializeField] private Material _dayMat;

    public void Change(EnvoirmentState state)
    {
        switch (state)
        {
            case EnvoirmentState.day:
                for (int i = 0; i <= _allNPC.Length; i++)
                {
                    _allNPC[i].NightInteraction();
                    UnityEngine.RenderSettings.skybox = _dayMat;
                }
                break;
            case EnvoirmentState.night:
                for(int i = 0; i <= _allNPC.Length; i++)
                {
                    _allNPC[i].DayInteraction();
                    UnityEngine.RenderSettings.skybox = _nightMat;
                }
                break;
        }
    }
}

public enum EnvoirmentState
{
    none = 0,
    day = 1, 
    night = 2,
    ray = 3,
}
