using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject prefab; // Префаб для спавна
    public Transform character; // Персонаж для перемещения

    private CommandInvoker invoker = new CommandInvoker();

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // ПКМ
        {
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ICommand spawnCommand = new SpawnPrefabCommand(prefab);
            invoker.InvokeCommand(spawnCommand, spawnPosition);
        }

        if (Input.GetMouseButtonDown(0)) // ЛКМ
        {
            Vector2 movePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ICommand moveCommand = new MoveCharacterCommand(character);
            invoker.InvokeCommand(moveCommand, movePosition);
        }
        if (Input.GetMouseButtonDown(2)) // Колесо мыши
        {
            invoker.Undo();
        }
    }

}
