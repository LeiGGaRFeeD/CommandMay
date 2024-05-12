using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabCommand : ICommand
{
    private GameObject prefab;
    private GameObject spawnedObject;
    private Vector2 position;

    public SpawnPrefabCommand(GameObject prefab, Vector2 position)
    {
        this.prefab = prefab;
        this.position = position;
    }

    public void Invoke()
    {
        spawnedObject = Object.Instantiate(prefab, position, Quaternion.identity);
    }

    public void Undo()
    {
        if (spawnedObject != null)
        {
            Object.Destroy(spawnedObject);
        }
    }
}