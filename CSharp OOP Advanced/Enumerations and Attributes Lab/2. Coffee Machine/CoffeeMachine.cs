﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CoffeeMachine
{
    private int coins;
    private IList<CoffeeType> coffeeSold;

    public CoffeeMachine() {
        this.coffeeSold = new List<CoffeeType>();
    }
    public IEnumerable<CoffeeType> CoffeesSold
    {
        get
        {
            return this.coffeeSold;
        }
    }
    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        if (this.coins >= (int)coffeePrice)
        {
            this.coffeeSold.Add(coffeType);
            coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin rem = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)rem;
    }
}
