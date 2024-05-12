using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterCommand : ICommand
{
    private Transform characterTransform;

    public MoveCharacterCommand(Transform characterTransform)
    {
        this.characterTransform = characterTransform;
    }

    public void Invoke(Vector2 position)
    {
        characterTransform.position = position;
    }
}
