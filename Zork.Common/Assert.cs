using System;
using System.Diagnostics;

namespace Zork
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, string message = null)
        {
            if (expression == false)
            {
                throw new Exception(message);
            }
        }

        public static void ArgumentIsNotNull(object value, string paramName = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
