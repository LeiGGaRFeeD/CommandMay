using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    public void InvokeCommand(ICommand command, Vector2 position)
    {
        command.Invoke(position);
    }
}
