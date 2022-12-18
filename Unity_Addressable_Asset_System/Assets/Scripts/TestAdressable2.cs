using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class TestAdressable2 : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] AssetReference rcf;
    void Start()
    {

        rcf.InstantiateAsync(obj.transform);
    }



}
