﻿namespace ExplicitInterfaces
{
    using System;

    public interface IPerson
    {
        string Name { get; }

        int Age { get; }

        void GetName();
    }
}