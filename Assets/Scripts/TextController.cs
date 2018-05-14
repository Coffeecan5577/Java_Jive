using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text Text;

    public enum CoffeeDrinks // Provides different stat boosts based on story.
    {
        No_Drink,
        Mocha,
        Espresso,
        Americano,
        Chai_Tea
    };

    public enum HealthCondition
    {
        Healthy,
        Nauseous,
        Epidemic_Level_Sick
    };

    public enum FactoryRoom
    {
        Office,
        Maintenance,
        Manufacturing,
        Bottling,
        Window
    };

    // Variables that will update throughout the game.
    private CoffeeDrinks CurrentDrink = CoffeeDrinks.No_Drink;
    private HealthCondition currentHealth = HealthCondition.Healthy;
    private FactoryRoom CurrentRoom = FactoryRoom.Office;


    // Use this for initialization
    void Start()
    {
        // Initialize states from the 3 different machines at game start.
        var startingDrink = CoffeeDrinks.No_Drink;
        var startingHealthCondition = HealthCondition.Healthy;
        var startingRoom = FactoryRoom.Office;
        Text.text =
            "Welcome. You have arrived in a broken coffee factory, where you must locate and consume \n different beverages to aid you in your escape. Your current location is the "  + startingRoom +
            "\n Press O to look around the office, M to move forward to maintenance." + "\n\n Check your health with H anytime, your current room with R, and drink a coffee with D";
    }
    
    // Update is called once per frame
    void Update()
    {
        var OKeyPressed = Input.GetKeyDown(KeyCode.O);


    }

    // These methods handle the text for our state machines when the appropriate key is pressed.
    void DisplayRoom(FactoryRoom room)
    {
        switch (room)
        {
            case FactoryRoom.Office:
            {
                Text.text = "You are currently in the office. ";
            }
            break;

            case FactoryRoom.Maintenance:
            {
                Text.text =
                    "You are in maintenance. You see broken glass all around,\n and can hear the wails of crushed coffee beans. \n Press L to look around, or N to continue to the next room.";
            }
            break;

            case FactoryRoom.Manufacturing:
            {
                Text.text =
                    "Manufacturing contains a secret. Press L to look around, or B to continue to the next room. ";
            }
            break;

            case FactoryRoom.Bottling:
            {
                Text.text =
                    "Broken chilled coffee bottles lay all around you. A massacre of bean grounding took place here not long ago. \n Press L to look around, or W to locate an exit.";
            }
            break;

            case FactoryRoom.Window:
            {
                Text.text =
                    "You discover a cracked window that you can escape through. Press T to throw your bottle \n and climb out, or L to wait and look around for stuff.";
            }
            break;
        }
    }

    void DisplayHealth(HealthCondition health)
    {
        switch (health)
        {
            case HealthCondition.Healthy:
            {
                Text.text = "You are perfectly healthy.";
            }
            break;

            case HealthCondition.Nauseous:
            {
                Text.text = "You begin to feel a little sick from the smells of the place.";
            }
            break;

            case HealthCondition.Epidemic_Level_Sick:
            {
                Text.text = "You just barfed all over the place. -2 to Immunity";
            }
            break;
        }
    }

    void DrinkCoffee(CoffeeDrinks drink)
    {
        switch (drink)
        {
            case CoffeeDrinks.No_Drink:
            {
                Text.text = "You currently have no drink. +1 to oxygen supply for drinking out of an empty bottle.";
            }
            break;

            case CoffeeDrinks.Americano:
            {
                Text.text = "You place your hand over your heart as you drink the beverage. +2 to Patriotism!";
            }
            break;

            case CoffeeDrinks.Mocha:
            {
                Text.text = "The strong flavor of the mocha overwhelms you. +3 to improved taste buds.";
            }
            break;

            case CoffeeDrinks.Espresso:
            {
                Text.text = "You're not sure if this is a single or double shot. Either way, +2 to movement speed.";
            }
            break;

            case CoffeeDrinks.Chai_Tea:
            {
                Text.text = "You can feel the tea cleanse your system. +2 to Immunity";
            }
            break;


        }
        
    }

}