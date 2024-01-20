using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Slime,
    Fire,
    Water,
    Wind,
    Electric
}

public enum BlockState
{
    Wood,
    Crevice,
    Lava,
    Obsidian,
    Cobblestone
}

public class AlchemyHandler : MonoBehaviour
{
    // FILL OUT THE REACTIONTABLE WITH PAIRS OF PLR AND BLCK STATES !!!!
    Dictionary<(PlayerState, BlockState), (PlayerState, BlockState)> ReactionTable;

    public void ReactPlayerWithBlock(ref PlayerState plrState, ref BlockState blckState)
    {
        // do something with plr and blck based on the combination
        PlayerState newPlrState;
        BlockState newBlckState;

        (newPlrState, newBlckState) = ReactionTable[(plrState, blckState)];

        // update their respective states
        plrState = newPlrState;
        blckState = newBlckState;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
