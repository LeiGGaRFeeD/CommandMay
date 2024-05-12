using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CommandInvoker
{
    private const int N = 10; // Ограничение очереди команд
    private Queue<ICommand> commandQueue = new Queue<ICommand>();

    public void InvokeCommand(ICommand command, Vector2 position)
    {
        if (commandQueue.Count >= N)
        {
            commandQueue.Dequeue(); // Удалите самую старую команду, если очередь полна
        }

        command.Invoke(position);
        commandQueue.Enqueue(command); // Добавьте новую команду в очередь
    }

    public void Undo()
    {
        if (commandQueue.Count > 0)
        {
            ICommand command = commandQueue.Dequeue();
            command.Undo(); // Отмените последнюю команду
        }
    }
}


