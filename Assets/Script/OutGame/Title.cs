using System;
using UnityEngine;
public class Title : MonoBehaviour
{
    [SerializeField] GameObject[] _titleObj;
    ITitle[] _titleInterfaces;
    private void Awake()
    {
        _titleInterfaces = Array.ConvertAll(_titleObj, x => x.GetComponent<ITitle>());
    }
    public void SetTitle()
    {
        Array.ForEach(_titleInterfaces, x => x.Init());
    }
}
