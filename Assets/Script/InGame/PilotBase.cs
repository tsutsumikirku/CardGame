using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotBase : MonoBehaviour
{
    [SerializeField]PilotTipe _pilotTipe;
}
public enum PilotTipe
{
    Defence,
    Annihilation,
    Suppress,
    Base
}
