using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helper
{
    public static class Extention
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {
            CreateGroup = 1,
            UpdateGroup,
            RemoveGroup,
            GetGroup,
            GetAllGroup
            

        }
        public static void MenuBar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1-Create Group\n" +
                    "2-Update Group\n" +
                    "3-Remove Group\n" +
                    "4-Get Group \n" +
                    "5-GetAll Group");
            Console.ResetColor();
        }
    }
}
