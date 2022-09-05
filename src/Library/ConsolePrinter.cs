using System;
/*
Para aplicar el principio SRP creo una nueva clase ConsolePrinter, puedo modificar la impresión sin tocar a las demás clases, separo la responsabilidad de imprimir a una nueva clase. 
Cada clase debe tener responsabilidad sobre una parte de la funcionalidad proporcionada por el software, y que la responsabilidad debe estar completamente encapsulada por la clase.
Los métodos y atributos de la clase deben estar estrechamente alineados con esa responsabilidad.  Una clase debe tener solo una razón para cambiar.
*/
namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}