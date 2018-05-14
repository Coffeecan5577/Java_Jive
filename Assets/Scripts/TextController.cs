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
    public CoffeeDrinks CurrentDrink = CoffeeDrinks.No_Drink;
    public HealthCondition currentHealth = HealthCondition.Healthy;
    public FactoryRoom CurrentRoom = FactoryRoom.Office;

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
                    "You are in maintenance. You see broken glass all around,\n and can hear the wails of crushed coffee beans.";
                break;
            }
        }
    }

    void DisplayHealth(HealthCondition health)
    {
        switch (health)
        {

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


        }
        
    }

}