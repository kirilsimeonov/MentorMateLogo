using CreateLogo.Common;
using CreateLogo.Logos.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateLogo.Models
{
    public abstract class Logo : ILogo
    {
        private string name;
        private int width;

        protected Logo(string name, int width)
        {
            Name = name;
            Width = width;
        }

        public string Name { get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ErrorMessages.InvalidLogoName);
                }
                name = value;
            }
        }

        public int Width
        {
            get => this.width;
            private set
            {
                if (value< Constants.MinimumWidth || value> Constants.MaximumWidth)
                {
                    throw new ArgumentException(ErrorMessages.InvalidInput);
                }
                width = value;
            }
        }

        
         public abstract char[,] CreateLogoMatrix();


    }
}
