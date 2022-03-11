using System;
using System.Reflection;

namespace P129Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\memme\Desktop\P129\Task\P129DemoLibrary\bin\Debug\netcoreapp3.1\P129DemoLibrary.dll");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.Name == "Student")
                {
                    //MemberInfo[] memberInfos = type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

                    MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        //.WriteLine(memberInfo.Name + " " + memberInfo.MemberType + " " + memberInfo.DeclaringType);

                        if (methodInfo.Name == "Write")
                        {
                            object ins = Activator.CreateInstance(type);

                            object[] paramss =
                            {
                                "World"
                            };

                            methodInfo.Invoke(ins, paramss);
                        }
                    }
                }
            }
        }
    }
}
