using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_01
{
    public enum Type
    {
        ACOUSTIC, ELECTRIC
    }

    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE,
        COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
    }

    public enum Builder
    {
        FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
    }

    static class EnumExtensionMethods
    {
        public static string GetString(this Type type)
        {
            switch (type)
            {
                case Type.ACOUSTIC: return "acoustic";
                case Type.ELECTRIC: return "electric";
                default: return "unspecified";
            }
        }

        public static string GetString(this Wood type) 
        { 
            switch(type) 
            {
                case Wood.INDIAN_ROSEWOOD: return "Indian Rosewood";
                case Wood.BRAZILIAN_ROSEWOOD: return "Brazilian Rosewood";
                case Wood.MAHOGANY: return "Mahogany";
                case Wood.MAPLE: return "Maple";
                case Wood.COCOBOLO: return "Cocobolo";
                case Wood.CEDAR: return "Cedar";
                case Wood.ADIRONDACK: return "Adirondack";
                case Wood.ALDER: return "Alder";
                case Wood.SITKA: return "Sitka";
                default: return "unspecified";
            }
        }

        public static string GetString(this Builder type) 
        {
            switch (type)
            {
                case Builder.FENDER: return "Fender";
                case Builder.MARTIN: return "Martin";              
                case Builder.GIBSON: return "Gibson";             
                case Builder.COLLINGS: return "Collings";             
                case Builder.OLSON: return "Olson";
                case Builder.RYAN: return "Ryan";               
                case Builder.PRS: return "PRS";
                default: return "unspecified";
            }

        }

    }
    class GuitarSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private int numStrings;
        private Wood backWood;
        private Wood topWood;

        public GuitarSpec(Builder builder, string model, Type type,
                    int numStrings, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.numStrings = numStrings;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public Builder getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public Type getType()
        {
            return type;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        public Wood getBackWood()
        {
            return backWood;
        }

        public Wood getTopWood()
        {
            return topWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if ((model != null) && (!(model == "")) &&
        (!(model.ToLower() == otherSpec.model.ToLower())))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;

        }
    }
}
