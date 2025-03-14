using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class CharacterDirector
    {
        public Character ConstructHero(HeroBuilder builder)
        {
            return builder.SetName("Артас Менетіл")
                          .SetYears(24)
                          .SetHairColor("Світло-русявий")
                          .SetEyesColor("Блакитний")
                          .SetWeight(95)
                          .SetHeight("190 см")
                          .AddClothing("Золоті лицарські обладунки Лордерону")
                          .AddItem("Срібний Молот")
                          .AddAction("Знищив Стратхольм")
                          .Build();
        }

        public Character ConstructEnemy(EnemyBuilder builder)
        {
            return builder.SetName("Король Ліч")
                          .SetYears(3000)
                          .SetHairColor("Сивий, покритий льодом")
                          .SetEyesColor("Світло-блакитний (палаючий магією)")
                          .SetWeight(120)
                          .SetHeight("210 см")
                          .AddClothing("Льодяний панцир")
                          .AddItem("Фростморн")
                          .AddItem("Шолом Домінування")
                          .AddAction("Очолив Плеть")
                          .AddAction("Прокляв Азерот")
                          .Build();
        }
    }
}
