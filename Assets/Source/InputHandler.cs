using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject prefab; // ������ ��� ������
    public Transform character; // �������� ��� �����������

    private CommandInvoker invoker = new CommandInvoker();

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // ���
        {
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ICommand spawnCommand = new SpawnPrefabCommand(prefab, spawnPosition);
            invoker.AddRightClickCommand(spawnCommand);
        }

        if (Input.GetKeyDown(KeyCode.Return)) // Enter
        {
            invoker.ExecuteRightClickCommands();
        }

        if (Input.GetMouseButtonDown(2)) // ������ ���� (����� ��� �������, ����� ���� ��������)
        {
            invoker.UndoRightClickCommand();
        }
    }
}