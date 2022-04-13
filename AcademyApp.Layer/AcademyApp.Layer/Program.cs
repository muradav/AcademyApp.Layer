using AcademyApp.Layer.Controllers;
using System;
using Utilities.Helper;

namespace AcademyApp.Layer
{
    class Program
    {
        //private static GroupService groupService;
        //public Program()
        //{
        //    groupService = new GroupService();
        //}
        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.Green, "Welcome");
            while (true)
            {
                GroupController groupController = new GroupController();                
                Extention.MenuBar();
                
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input < 7 && input > 0)
                {
                    switch (input)
                    {                       

                        case (int)Extention.Menu.CreateGroup:
                            groupController.CreateGroup();
                            break;
                        case (int)Extention.Menu.UpdateGroup:
                            groupController.Update();
                            break;
                        case (int)Extention.Menu.RemoveGroup:
                            groupController.RemoveGroup();
                            break;
                        case (int)Extention.Menu.GetGroup: 
                                groupController.GetGroup();
                            break;
                        case (int)Extention.Menu.GetAllGroup:
                            groupController.GetAllGroup();
                            break;
                    }
                }

            }
        }
    }
}
