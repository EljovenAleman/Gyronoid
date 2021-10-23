using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerControllerFactory
{
    public static IPlayerController playerController = new PCPlayerController();

    //public static IPlayerController playerController = new MobilePlayerController();
}
