namespace SetToolsVersion
{
    using System;

    public static class Throw
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the given value is null
        /// </summary>
        public static void IfNull<T>(T value, string parameterName)
        {
            Throw<ArgumentNullException>.If(value == null, parameterName);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the given condition is true
        /// </summary>
        public static void If(bool condition, string parameterName)
        {
            Throw<ArgumentException>.If(condition, parameterName);
        }
    }

    public static class Throw<TException>
        where TException : Exception
    {
        /// <summary>
        /// Throws an exception of type <see cref="TException"/> if the condition is true
        /// </summary>
        public static void If(bool condition, string message)
        {
            if (condition)
            {
                throw Create(message);
            }
        }

        private static TException Create(string message)
        {
            return (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
