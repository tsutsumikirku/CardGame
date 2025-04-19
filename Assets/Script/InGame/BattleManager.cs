using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    BattleState _battleState;
    MobileSuiteBase[] _mobileSuites;
    
    public void Init()
    {
        
    }
    public void Update()
    {
        switch (_battleState)
        {
            case BattleState.Waiting:
                break;
            case BattleState.Battle:
                System.Array.ForEach(_mobileSuites, x => x.ManualUpdate());
                break;
        }
    }
}
public enum BattleState
{
    Waiting,
    Battle
}
