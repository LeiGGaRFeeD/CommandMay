using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabCommand : ICommand
{
    private GameObject prefab;

    public SpawnPrefabCommand(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void Invoke(Vector2 position)
    {
        Object.Instantiate(prefab, position, Quaternion.identity);
    }
}
