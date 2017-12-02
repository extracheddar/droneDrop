using UnityEngine;

public static class CommonObjects
{
    private static GameController gameController;
    private static GameObject player;
    private static Thrust playerThrust;

    public static GameController GetGameController () {
        return gameController ?? (gameController = GameObject.FindGameObjectWithTag(TagConstants.GAME_CONTROLLER)
                   .GetComponent<GameController>());
    }
    
    public static GameObject GetPlayer () {
        return player ?? (player = GameObject.FindGameObjectWithTag(TagConstants.PLAYER));
    }

    public static Thrust GetThrust () {
        return playerThrust ?? (playerThrust = GetPlayer().GetComponent<Thrust>());
    }

}