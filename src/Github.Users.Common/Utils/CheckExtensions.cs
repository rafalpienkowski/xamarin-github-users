using System;

namespace Github.Users.Common.Utils
{
    public static class CheckExtensions
    {
        public static void IsNull(this object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
