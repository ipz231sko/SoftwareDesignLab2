using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetWeight(double weight);
        ICharacterBuilder SetHairColor(string color);
        ICharacterBuilder SetEyeColor(string color);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddInventoryItem(string item);
        Character Build();
    }
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Height: {Height}, Weight: {Weight}, Hair Color: {HairColor}, Eye Color: {EyeColor}, Clothing: {Clothing}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
        }
    }
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetWeight(double weight)
        {
            _character.Weight = weight;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string color)
        {
            _character.EyeColor = color;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetWeight(double weight)
        {
            _character.Weight = weight;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string color)
        {
            _character.EyeColor = color;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
    public class CharacterDirector
    {
        private readonly ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character BuildHero()
        {
            return _builder.SetName("Michael Scofiled")
                .SetHeight(1.85)
                .SetWeight(80)
                .SetHairColor("Brunette")
                .SetEyeColor("Blue")
                .SetClothing("Casual clothes")
                .AddInventoryItem("Plan")
                .AddInventoryItem("Mind")
                .Build();
        }

        public Character BuildEnemy()
        {
            return _builder.SetName("Theodore T-Bag Bagwell")
                .SetHeight(1.75)
                .SetWeight(70)
                .SetHairColor("Brunette")
                .SetEyeColor("Brown")
                .SetClothing("Casual clothes")
                .AddInventoryItem("Blade")
                .AddInventoryItem("Mind")
                .Build();
        }
    }
}
