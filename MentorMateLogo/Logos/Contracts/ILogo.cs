using System;
using System.Collections.Generic;
using System.Text;

namespace CreateLogo.Logos.Contracts
{
    public interface ILogo
    {
        string Name { get; }

        int Width { get;  }

        char[,] CreateLogoMatrix();
    }
}
