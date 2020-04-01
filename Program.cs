using System;
    public class employeeWeges
    {   
        
        public int checkAttendance()
        {
            Random rand = new Random();
            int num = rand.Next(2);
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        public int calculateEmployeeDailyWeges(int EMPLOYEE_WEGES_PER_HOUR, int FULL_DAY_HOUR)
        {
            return EMPLOYEE_WEGES_PER_HOUR * FULL_DAY_HOUR; 
        }
        
    }

    class MainD
    {
    //private static int EMPLOYEE_PRESENT_OR_ABSENT;
    public static void Main(string[] args)
        {
            int EMPLOYEE_WEGES_PER_HOUR = 20;
            int FULL_DAY_HOUR = 8;
            int PARTTIME_HOUR = 4;
            int ABSENT = 0;
            int EMPLOYEE_PRESENT_OR_ABSENT;
            int EMPLOYEE_WEGES;
            employeeWeges emp = new employeeWeges();
        EMPLOYEE_PRESENT_OR_ABSENT = emp.checkAttendance();
            if(EMPLOYEE_PRESENT_OR_ABSENT==0)
            {
                EMPLOYEE_WEGES = emp.calculateEmployeeDailyWeges(EMPLOYEE_WEGES_PER_HOUR, FULL_DAY_HOUR);
            }
            else
            {
                EMPLOYEE_WEGES = ABSENT;
            }
                Console.WriteLine(EMPLOYEE_WEGES);
        }
    }