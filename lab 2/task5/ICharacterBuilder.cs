using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetYears(int years);
        ICharacterBuilder SetHairColor(string color);
        ICharacterBuilder SetEyesColor(string color);
        ICharacterBuilder SetWeight(int weight);
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder AddAction(string action);
        ICharacterBuilder AddItem(string item);
        ICharacterBuilder AddClothing(string clothing);
        Character Build();
    }


}
