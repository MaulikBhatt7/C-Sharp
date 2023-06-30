/*  
    Write a program to create a class Staff having data members as Name,
    Department, Designation, Experience & Salary. Accept this data for 5
    different staffs and display only names & salary of those staff who are
    HOD.
*/


using System;
class Staff
{
  
   
    List<Dictionary<String, dynamic>> list = new List<Dictionary<String, dynamic>>();
    void getDetails()
    {
        

        for (int i = 0; i < 5; i++)
        {

            Dictionary<String, dynamic> dict = new Dictionary<String, dynamic>();

            Console.Write("Enter Name : ");
            dict["Name"] = Console.ReadLine();

            Console.Write("Enter Department : ");
            dict["Department"] = Console.ReadLine();

            Console.Write("Enter Designation : ");
            dict["Designation"] = Console.ReadLine();

            Console.Write("Enter Experience : ");
            dict["Experience"] = Console.ReadLine();

            Console.Write("Enter Salary : ");
            dict["Salary"] = Console.ReadLine();

            this.list.Add(dict);
        }
    }

    void DisplayDetails()
    {
        foreach (Dictionary<String, dynamic> dict in list)
        {
            if (dict["Department"].ToUpper() == "HOD")
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Name : " + dict["Name"]);
                Console.WriteLine("Salary : " + dict["Salary"]);
            }
        }
    }

    public static void Main(String[] args)
    {
        Staff st = new Staff();
        st.getDetails();
        st.DisplayDetails();
        Console.ReadLine();
    }
}
