using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationLibrary.Figures
{
    public abstract class Figure
    // почему абстрактный класс, а не интерфейс?
    // 1) поскольку ТЗ сформулировано максимально кратко, позволю себе домысел, что у фигур может быть не только общий метод, но также и 
    // общие поля (местоположение, название, цвет, тэги и т.д.)
    // 2) лично я предпочитаю считать интерфейсы "описанием неких общих свойств", а класс-родитель - "сутью",
    // потому для меня данное решение выглядит логичным
    {
        /// <summary>
        /// Gets an area value of the figure.
        /// </summary>
        /// <returns>area</returns>
        public abstract double GetArea();
        /// <summary>
        /// Gets a perimeter value of the figure.
        /// </summary>
        /// <returns>perimeter</returns>
        public abstract double GetPerimeter();
    }

    

}
