using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Controles controles;

    public static void Init(Player myPlayer)
    {
        controles = new Controles();

        controles.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };
        

    }

    public static void Gamemode()
    {
        controles.Game.Enable();
    }
}
