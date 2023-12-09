using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;

namespace SchoolDetails.ConsoleApplication
{
  public   class MenuDriven
    {
        int a;
        private readonly ISchoolDetailsRepository obj1;

        public MenuDriven()
        {
            obj1 = new SchoolDetailsRepository();
        }

        public void Menu()
        {

            do
            {

                Console.WriteLine("1.Inset");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Read");
                Console.WriteLine("5.Read by Number");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter you choice");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {

                            SchoolDetail shl = new SchoolDetail();
                            Console.WriteLine("Enter the SchoolName");
                            shl.SchoolName = Console.ReadLine();

                            Console.WriteLine("Enter the Address");
                            shl.Address = (Console.ReadLine());

                            shl.StortedDate = DateTime.Today;

                            Console.WriteLine("Enter the PhoneNumber");
                            shl.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("Enter the Email_id");
                            shl.Email_id = (Console.ReadLine());

                          
                            var Result = obj1.InsertSP(shl);
                           
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Enter the Id number");
                            int N = Convert.ToInt32(Console.ReadLine());

                            SchoolDetail shl = new SchoolDetail();

                            Console.WriteLine("Enter the SchoolName");
                            shl.SchoolName = Console.ReadLine();

                            Console.WriteLine("Enter the Address");
                            shl.Address = (Console.ReadLine());

                            shl.StortedDate = DateTime.Today;

                            Console.WriteLine("Enter the PhoneNumber");
                            shl.PhoneNumber = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the Email_id");
                            shl.Email_id = (Console.ReadLine());

                            obj1.UpdateSchoolDetailsByIdSP(N, shl);


                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Enter the Id number to delete");
                            int N = Convert.ToInt32(Console.ReadLine());

                            obj1.DeleteSchoolDetailsByIdSP(N);
                            var rec = obj1.ReadSP();
                            Console.WriteLine("Id    SchoolName    Address                                     StortedDate           PhoneNumber    Email_id ");
                            foreach (var p in rec)
                            {
                                Console.WriteLine($"{p.Id}    {p.SchoolName}    {p.Address}    {p.StortedDate}    {p.PhoneNumber}    {p.Email_id}");
                            }

                        }
                        break;

                    case 4:
                        {
                            var recd = obj1.ReadSP();
                            Console.WriteLine("Id    SchoolName    Address                                   StortedDate           PhoneNumber    Email_id ");
                            foreach (var p in recd)
                            {
                                Console.WriteLine($"{p.Id}    {p.SchoolName}    {p.Address}    {p.StortedDate}    {p.PhoneNumber}    {p.Email_id}");
                            }


                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("Enter the Id to Find School Details By Id");

                            int N = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Id    SchoolName    Address                                    StortedDate          PhoneNumber    Email_id ");
                            var recd = obj1.FindSchoolDetailsByIdSP(N); 
                            if (recd == null)
                                Console.WriteLine("Not a valid Number");
                            else
                                Console.WriteLine($"{recd.Id}    {recd.SchoolName}    {recd.Address}    {recd.StortedDate}    {recd.PhoneNumber}    {recd.Email_id}");


                        }


                        break;

                    case 6:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("number not matched");
                            break;
                        }


                }
            } while (6 > a);

        }
    }
}
