using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class TestAdressable : MonoBehaviour
{
    [SerializeField] GameObject prefabs;
    AsyncOperationHandle handle;

    public void ClickLoad()
    {
        Addressables.LoadAssetAsync<GameObject>("Cube").Completed +=
            (AsyncOperationHandle<GameObject> obj) =>
            {
                handle = obj;
                prefabs = obj.Result;
                Instantiate(prefabs);
                prefabs.transform.position= Vector3.zero;
            };
    }

    public void ClickUnload()
    {
        Addressables.Release(handle);
        prefabs = null;
    }
}
