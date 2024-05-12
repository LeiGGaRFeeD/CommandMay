using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabCommand : ICommand
{
    private GameObject prefab;
    private GameObject lastSpawnedObject;

    public SpawnPrefabCommand(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void Invoke(Vector2 position)
    {
        lastSpawnedObject = Object.Instantiate(prefab, position, Quaternion.identity);
    }

    public void Undo()
    {
        if (lastSpawnedObject != null)
        {
            Object.Destroy(lastSpawnedObject);
        }
    }
}
