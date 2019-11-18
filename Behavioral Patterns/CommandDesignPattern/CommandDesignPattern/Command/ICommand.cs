using System;

namespace CommandDesignPattern.Command
{
    public interface ICommand
    {
         String Name { get; }

        int Execute();
    }
}