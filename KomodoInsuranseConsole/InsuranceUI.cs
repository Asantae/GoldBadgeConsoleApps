using KomodoInsuranceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranseConsole
{
    public class InsuranceUI
    {
        private readonly InsuranceRepository _insuranceRepo = new InsuranceRepository();
        public void Run()
        {
            SeedContent();
            insuranceUI();
        }
        public void insuranceUI()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? \n \n " +
                    "1) Add Badge \n \n " +
                    "2) Update A Badge \n \n " +
                    "3) See All Badges \n \n " +
                    "4) Exit Program ");
                int userResponseMenu = Convert.ToInt32(Console.ReadLine());
                //userInteraction();
                switch (userResponseMenu)
                {
                    case 1:
                        AddBadge();
                        break;
                    case 2:
                        UpdateBadge();
                        break;
                    case 3:
                        SeeAllBadges();
                        break;
                    case 4:
                        continueToRun = false;
                        break;
                }
            }
        }

        public void AddBadge()
        {
            {
                Console.Clear();
                List<string> DoorNames = new List<string>();
                Console.Write("Please enter the badge number: ");
                int empNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the door you want this badge to access: ");
                string doorNum = Console.ReadLine();
                DoorNames.Add(doorNum);
                bool answer = true;
                while (answer)
                {
                    Console.Write("Did you want to add another door?(y/n)");
                    string adminAnswer = Console.ReadLine().ToLower();
                    if (adminAnswer == "y")
                    {
                        Console.Write("Please enter the door you want this badge to access: ");
                        string doorNum2 = Console.ReadLine();
                        DoorNames.Add(doorNum2);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (adminAnswer == "n")
                    {
                        answer = false;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                //InsuranceItems content = new InsuranceItems();
                Console.Clear();
                _insuranceRepo.AddContentToDirectory(empNum, DoorNames);

            }
        }

        public void UpdateBadge()
        {

        }

        public void SeeAllBadges()
        {
            Console.Clear();
            //var pair = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> Contents = _insuranceRepo.GetContents();
            Console.WriteLine("BadgeID\t      Door Access\t");
            foreach (var pair in Contents)
            {
                Console.WriteLine($"{pair.Key}\t      " + $"{pair.Value}\t");
            }
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
        }
        public void DisplayAll()
        {
            //Console.WriteLine($"{pair.Key}\t      " + $"\t");
        }
        public void SeedContent()
        {

        }
    }
}
