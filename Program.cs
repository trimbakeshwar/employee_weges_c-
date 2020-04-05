using System;
using System.Collections.Generic;
namespace employeeComputation
{
    

    class calling
    {
        /*print dictionary in foreach function*/
        //private static int EMPLOYEE_PRESENT_OR_ABSENT;
        public static void Main(string[] args)
        {
          
            employeeWeges emp = new employeeWeges();
            Dictionary<String, int> dailyWeges = new Dictionary<String, int>();
            int MONTHLY_WEGES = emp.monthlyWeges(dailyWeges);
            Console.WriteLine(MONTHLY_WEGES);
            foreach (KeyValuePair<String, int> itome in dailyWeges)
            {
                Console.WriteLine($"{itome.Key} : {itome.Value}");
            }


        }
    }
}