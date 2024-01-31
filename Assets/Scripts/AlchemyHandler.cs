using System;
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
    None,
    Wood,
    Crevice,
    Lava,
    Obsidian,
    Cobblestone,

    OrbSlime,
    OrbFire,
    OrbWater,
    OrbWind,
    OrbElectric
}



public class AlchemyHandler : MonoBehaviour
{
    // [TODO]: FILL OUT THE REACTIONTABLE WITH PAIRS OF PLR AND BLCK STATES !!!!
    Dictionary<(PlayerState, BlockState), (PlayerState, BlockState)> ReactionTable;

    public void InteractPlayerWithOrb(ref  PlayerState plrState, ref BlockState blckState, BlockState newBlckState = BlockState.None)
    {
        plrState = (PlayerState)Enum.Parse(typeof(PlayerState), blckState.ToString().Remove(0, 3));     // Remove 'Orb'

        blckState = newBlckState;
    }

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
}
