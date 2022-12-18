using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class TestAdressable3 : MonoBehaviour
{
    [SerializeField] AssetReference Rcf;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        Rcf.InstantiateAsync(Vector3.zero,Quaternion.identity).Completed += 
            (AsyncOperationHandle<GameObject> handle ) =>
            {
                obj = handle.Result;

                Invoke("ReleaseDestroy", 3.0f);
            };
    }

    private void ReleaseDestroy()
    {
        Rcf.ReleaseInstance(obj);
    }
}
