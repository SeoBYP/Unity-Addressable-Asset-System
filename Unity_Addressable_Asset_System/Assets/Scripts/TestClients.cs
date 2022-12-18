using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClients : MonoBehaviour
{
    public TestAdressable testAdressable;


    private void OnGUI()
    {
        if(GUILayout.Button("Load Cube"))
        {
            testAdressable.ClickLoad();
        }
        if(GUILayout.Button("UnLoad Cube"))
        {
            testAdressable.ClickUnload();
        }
    }
}
