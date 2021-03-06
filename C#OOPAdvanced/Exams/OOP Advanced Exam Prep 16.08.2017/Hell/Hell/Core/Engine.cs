﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private IInputReader reader;
    private IOutputWriter writer;
    private ICommandInterpreter commandInterpreter;

    public Engine(IInputReader reader, IOutputWriter writer, ICommandInterpreter interpreter)
    {
        this.reader = reader;
        this.writer = writer;
        this.commandInterpreter = interpreter;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            List<string> arguments = this.ParseInput(inputLine);

            string resultMessage = this.commandInterpreter.InterpretCommand(arguments);

            this.writer.WriteLine(resultMessage);
            isRunning = !this.ShouldEnd(inputLine);
        }
    }

    private List<string> ParseInput(string input)
    {
        return input
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
    }

    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}