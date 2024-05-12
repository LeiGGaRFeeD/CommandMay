using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterCommand : ICommand
{
    private Transform characterTransform;
    private Vector2 previousPosition;

    public MoveCharacterCommand(Transform characterTransform)
    {
        this.characterTransform = characterTransform;
        this.previousPosition = characterTransform.position; // Сохраните начальную позицию
    }

    public void Invoke(Vector2 position)
    {
        previousPosition = characterTransform.position; // Сохраните текущую позицию перед перемещением
        characterTransform.position = position;
    }

    public void Undo()
    {
        characterTransform.position = previousPosition; // Верните персонажа на предыдущую позицию
    }
}
