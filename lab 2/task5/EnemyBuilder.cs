using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetYears(int years)
        {
            _character.Years = years;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder SetEyesColor(string color)
        {
            _character.EyesColor = color;
            return this;
        }

        public ICharacterBuilder SetWeight(int weight)
        {
            _character.Weight = weight;
            return this;
        }

        public ICharacterBuilder SetHeight(string height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder AddAction(string action)
        {
            _character.Actions.Add(action);
            return this;
        }

        public ICharacterBuilder AddItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder AddClothing(string clothing)
        {
            _character.Clothing.Add(clothing);
            return this;
        }

        public Character Build() => _character;
    }

}
