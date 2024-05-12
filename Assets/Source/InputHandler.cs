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
            ICommand spawnCommand = new SpawnPrefabCommand(prefab);
            invoker.InvokeCommand(spawnCommand, spawnPosition);
        }

        if (Input.GetMouseButtonDown(0)) // ���
        {
            Vector2 movePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ICommand moveCommand = new MoveCharacterCommand(character);
            invoker.InvokeCommand(moveCommand, movePosition);
        }
        if (Input.GetMouseButtonDown(2)) // ������ ����
        {
            invoker.Undo();
        }
    }

}
