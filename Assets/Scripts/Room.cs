using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Room : MonoBehaviour
{
    [SerializeField]
    private readonly string roomName;

    [SerializeField]
    private readonly Vector2 coordinate;

    void Start()
    {
        gameObject.name = roomName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
