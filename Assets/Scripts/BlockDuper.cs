using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockDuper : MonoBehaviour
{
    public GameObject newGameObject;
    
    public void InstantiateNewObject()
    {
        Instantiate(newGameObject);
    }
}
