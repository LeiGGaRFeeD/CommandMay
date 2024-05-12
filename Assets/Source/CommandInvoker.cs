using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CommandInvoker
{
    private const int N = 10; // ����������� ������� ������
    private Queue<ICommand> commandQueue = new Queue<ICommand>();

    public void InvokeCommand(ICommand command, Vector2 position)
    {
        if (commandQueue.Count >= N)
        {
            commandQueue.Dequeue(); // ������� ����� ������ �������, ���� ������� �����
        }

        command.Invoke(position);
        commandQueue.Enqueue(command); // �������� ����� ������� � �������
    }

    public void Undo()
    {
        if (commandQueue.Count > 0)
        {
            ICommand command = commandQueue.Dequeue();
            command.Undo(); // �������� ��������� �������
        }
    }
}


