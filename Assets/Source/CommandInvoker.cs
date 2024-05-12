using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Queue<ICommand> rightClickCommandsQueue = new Queue<ICommand>();
    private Stack<ICommand> executedCommandsStack = new Stack<ICommand>();

    public void AddRightClickCommand(ICommand command)
    {
        rightClickCommandsQueue.Enqueue(command);
    }

    public void ExecuteRightClickCommands()
    {
        while (rightClickCommandsQueue.Count > 0)
        {
            ICommand command = rightClickCommandsQueue.Dequeue();
            command.Invoke();
            executedCommandsStack.Push(command);
        }
    }

    public void UndoRightClickCommand()
    {
        if (executedCommandsStack.Count > 0)
        {
            ICommand command = executedCommandsStack.Pop();
            command.Undo();
        }
    }
}