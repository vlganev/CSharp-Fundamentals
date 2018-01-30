﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Soldier : ISoldier
{
    private string id;
    private string firstName;
    private string lastName;

    public Soldier(string id, string firstName, string lastName)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Id => this.id;
    public string FirstName => this.firstName;
    public string LastName => this.lastName;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");

        return builder.ToString().Trim();
    }
}