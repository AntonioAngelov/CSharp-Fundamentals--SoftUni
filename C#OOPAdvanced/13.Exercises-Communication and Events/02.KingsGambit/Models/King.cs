﻿using System;

public class King
{
    public event EventHandler UnderAttack;

    public King(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public void OnUnderAttack()
    {
        Console.WriteLine($"King {this.Name} is under attack!");

        if (this.UnderAttack != null)
        {
            UnderAttack(this, new EventArgs());
        }
    }
}
