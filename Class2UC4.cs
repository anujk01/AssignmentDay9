using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class Class2UC4
    {
        public void DeletetheName()
        {
            if (UC2.AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in UC2.AddressBook)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        UC2.AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}