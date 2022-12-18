using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class Create : MonoBehaviour
{
    [SerializeField] GameObject parent;
    public void _CreatePengSoo()
    {
        Addressables.InstantiateAsync("Æë¼ö", parent.transform);
    }
}
