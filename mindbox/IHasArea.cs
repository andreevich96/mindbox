using System;

namespace mindbox
{
    /// <summary>
    /// Интерфейс для фигур имеющих площадь.
    /// </summary>
    public interface IHasArea
    {
        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        double Area { get; set; }
    }
}
