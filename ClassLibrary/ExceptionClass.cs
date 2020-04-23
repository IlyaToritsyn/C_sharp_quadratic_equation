using System;

namespace ClassLibrary
{
    /// <summary>
    /// Исключение: коэффициент не пропарщен.
    /// </summary>
    public class NotParsedException : Exception
    {
        /// <summary>
        /// Проверка: пропарсился ли коэффициент a
        /// </summary>
        public bool IsAParsed { get; }

        /// <summary>
        /// Проверка: пропарсился ли коэффициент b
        /// </summary>
        public bool IsBParsed { get; }

        /// <summary>
        /// Проверка: пропарсился ли коэффициент c
        /// </summary>
        public bool IsCParsed { get; }

        public NotParsedException(bool isAParsed, bool isBParsed, bool isCParsed)
        {
            IsAParsed = isAParsed;
            IsBParsed = isBParsed;
            IsCParsed = isCParsed;
        }

        public NotParsedException(string message) : base(message)
        {

        }
    }
}
