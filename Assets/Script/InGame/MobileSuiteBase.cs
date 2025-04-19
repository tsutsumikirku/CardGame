using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobileSuiteBase : MonoBehaviour
{
    [SerializeField] float _mobility;
    [SerializeField] float _longRangeAttack;
    [SerializeField] float _lowRangeAttack;
    [SerializeField] float _hitPoint;
    MobileSuiteState _state;
    public MobileSuiteState MobileSuiteState { get { return _state; } }
    public void ManualUpdate()
    {
        switch (_state)
        {
            case MobileSuiteState.Waiting:
                WaitingUpdate();
                break;
            case MobileSuiteState.ReadyForDeployment:
                ReadyForDeploymentUpdate();
                break;
            case MobileSuiteState.InDeployment:
                InDeploymentUpdate();
                break;
        }
    }
    void WaitingUpdate()
    {
        
    }
    void ReadyForDeploymentUpdate()
    {
        
    }
    void InDeploymentUpdate()
    {

    }
}
public enum MobileSuiteState
{
    Waiting,
    ReadyForDeployment,
    InDeployment
}
public enum MobileSuiteTipe
{
    LowRange,
    LongRange,
    Mobility
}
