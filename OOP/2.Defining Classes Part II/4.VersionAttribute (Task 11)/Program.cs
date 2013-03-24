using System;

namespace _4.VersionAttribute
{
    [VersionAttribute(1,1)]
    [VersionAttribute(2, 2)]
    [VersionAttribute(4,16)]
    class Demo
    {
        static void Main()
        {
            Type type = typeof(Demo);
            object[] versionAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine("The version of the class Demo is {0}.{1}",
                    versionAttribute.Major, versionAttribute.Minor);
            }
            Console.WriteLine();
        }
    }
}