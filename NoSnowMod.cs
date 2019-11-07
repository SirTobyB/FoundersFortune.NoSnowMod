using UnityEngine;

// It's good practice to keep all of your source code in your own namespace
// Founders' Fortune doesn't use an own namespace though.
namespace NoSnowMod
{
    // System.Serializable is obligatory.
    [System.Serializable]
    public class NoSnowMod : Mod 
    {
        // The Load() function is called when the mods are loaded into memory.
        // This happens either before entering the colonist selection screen when you click on "New Game"
        // or during the loading process when you load an old one
        public override void Load() 
        {
            MonoBehaviour.print("loaded mod NoSnow");
        }

        // Start() is called after the game world has been loaded and initialized
        // This function is called every time a world has been loaded, doesn't matter if it's a new game or loaded from a save game
        public override void Start() 
        {
            MonoBehaviour.print("started mod NoSnow");
        }

        // Update() is called every single frame.
        // Be very careful that you don't put anything too performance-heavy directly in here or you will easily slow down the player's game.
        public override void Update() 
        {
            // Disable the moving of the snowflake objects, so that they no longer become visible
            WorldScripts.Instance.weatherManager.precipitationManager.SetIsSnowing(false, false);
        }
    }
}

