using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterCommand : ICommand
{
    private Transform characterTransform;
    private Vector2 originalPosition;
    private Vector2 newPosition;

    public MoveCharacterCommand(Transform characterTransform, Vector2 newPosition)
    {
        this.characterTransform = characterTransform;
        this.originalPosition = characterTransform.position;
        this.newPosition = newPosition;
    }

    public void Invoke()
    {
        characterTransform.position = newPosition;
    }

    public void Undo()
    {
        characterTransform.position = originalPosition;
    }
}