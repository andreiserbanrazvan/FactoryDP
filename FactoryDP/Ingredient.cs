using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    /// <summary>
    /// Product
    /// </summary>
    abstract class Ingredient { }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    class Mayonnaise : Ingredient { }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    class Bread : Ingredient { }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    class Turkey : Ingredient { }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    class Lettuce : Ingredient { }
    
    /// <summary>
    /// Creator
    /// </summary>
     abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        //Factory method
        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients;  }
        }
    }

    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }

}


