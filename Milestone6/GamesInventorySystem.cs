using System.Diagnostics;

//write code to build a Games Inventory Systems in c# unity: Demonstrate CRUD Operations

using UnityEngine;
using System.Collections;

public class GameInventorySystem : MonoBehaviour
{
    //Create an array to store our games
    Game[] games;

    //CRUD operations
    //Create
    public void CreateGame(Game game)
    {
        //add the game to the array
        games.Add(game);

        //print out a message to show the game has been added
        Debug.Log("Game '" + game.GameName + "' has been added to the inventory");
    }

    //Read
    public void ReadGame(int index)
    {
        //print out the details of the game
        Debug.Log("Game Name: " + games[index].GameName);
        Debug.Log("Game Description: " + games[index].GameDescription);
        Debug.Log("Game Genre: " + games[index].GameGenre);
        Debug.Log("Game Release Date: " + games[index].GameReleaseDate);
    }

    //Update
    public void UpdateGame(Game game, int index)
    {
        //update the game
        games[index] = game;

        //print out a message to show the game has been updated
        Debug.Log("Game '" + game.GameName + "' has been updated in the inventory");
    }

    //Delete
    public void DeleteGame(int index)
    {
        //remove the game from the array
        games.RemoveAt(index);

        //print out a message to show the game has been deleted
        Debug.Log("Game at index " + index + " has been deleted from the inventory");
    }

    //class to store game details
    public class Game
    {
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GameGenre { get; set; }
        public string GameReleaseDate { get; set; }
    }
}
