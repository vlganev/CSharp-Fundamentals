﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Commando : SpecialisedSoldier, ICommando
{
    private IList<IMission> missions;

    public Commando(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<IMission>();
    }

    public IList<IMission> Missions => this.missions;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .AppendLine(base.ToString())
            .AppendLine("Missions:");

        foreach (var mission in this.missions)
        {
            builder.AppendLine($"  {mission}");
        }

        return builder.ToString().Trim();
    }
}