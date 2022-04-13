using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace AcademyApp.Layer.Controllers
{
    public class GroupController
    {
        private GroupService groupService;
        public GroupController()
        {
            groupService = new GroupService();
        }
        public void CreateGroup()
        {
            Console.Clear();
        EnterName:
            Extention.Print(ConsoleColor.Green, $"Group Name");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, $"Group Size");
            string groupSize = Console.ReadLine();
            int size;


            bool isSize = int.TryParse(groupSize, out size);
            if (isSize)
            {
                Group group = new Group
                {
                    Name = name,
                    MaxSize = size
                };

                groupService.Create(group);
                Extention.Print(ConsoleColor.Green, $"{group.Name} created");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Duzgun daxil et");
                goto EnterName;
            }
        }
        public void GetAllGroup()
        {

            Console.Clear();

            foreach (var item in groupService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveGroup()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Please enter ID");
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{groupService.Delete(id).Name}");

        }
        public void GetGroup()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Please enter Group ID");
            int id= int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green,$"{groupService.GetGroup(id).Name}");
        }
        public  void Update()
        {
            Console.Clear();
        UpdateGroup:
            Extention.Print(ConsoleColor.Green, "Please enter Group ID");

            string groupId = Console.ReadLine();
            int id;
            Extention.Print(ConsoleColor.Green, "Please enter new Group name");
            string name = Console.ReadLine();
            bool isId = int.TryParse(groupId, out id);
            if (isId)
            {
                Group group = new Group
                {
                    Name = name
                };
                groupService.Create(group);
                Extention.Print(ConsoleColor.Green, $"Group Name changed to {groupService.Update(id,group).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto UpdateGroup;
            }
            
            
        
        }
    }
}
