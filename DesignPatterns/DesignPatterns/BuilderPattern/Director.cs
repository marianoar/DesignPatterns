using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepararMargerita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 lemons");
            _builder.AddIngredients("sal");
            _builder.AddIngredients("1/2 taza de Tequila");
            _builder.AddIngredients("3/4 taza de licor de Naranja");
            _builder.AddIngredients("5 cubitos de hielo");
            _builder.Mix();
            _builder.Rest(250);
        }

        public void PrepararPiñaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(5);
            _builder.SetWater(6);
            _builder.AddIngredients("500 cc de Ron");
            _builder.AddIngredients("500 cc crema de coco");
            _builder.AddIngredients("1000cc de jugo de piña");
            _builder.Mix();
            _builder.Rest(250);

        }
    }
}
