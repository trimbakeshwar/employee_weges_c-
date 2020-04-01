using System;
    public class employeeWeges
    {
    int EMPLOYEE_WEGES;
    int employee_Monthly_weges;
    int countDays;
    int WORKING_DAYS;
    int HOURS;
    int TOTAL_MONTHLY_HOUR;
    public employeeWeges()
    {
        EMPLOYEE_WEGES=0;
        employee_Monthly_weges=0;
        countDays = 0;
        WORKING_DAYS = 20;
        HOURS = 0;
        TOTAL_MONTHLY_HOUR = 100;
    }
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
      
        public int monthlyWeges(int EMPLOYEE_WEGES_PER_HOUR, int FULL_DAY_HOUR, int PARTTIME_HOUR, int ABSENT)
        {
            int EMPLOYEE_PRESENT_OR_ABSENT=0;
            int PARTTIME_OR_FULLTIME=0;
            while (countDays != WORKING_DAYS && HOURS != TOTAL_MONTHLY_HOUR )
            {
                EMPLOYEE_PRESENT_OR_ABSENT = this.checkAttendance();
                switch(EMPLOYEE_PRESENT_OR_ABSENT)
                {
                case 0:
                    PARTTIME_OR_FULLTIME = this.checkAttendance();
                    switch (PARTTIME_OR_FULLTIME)
                    {
                        case 0:
                            EMPLOYEE_WEGES = this.calculateEmployeeDailyWeges(EMPLOYEE_WEGES_PER_HOUR, FULL_DAY_HOUR);
                            HOURS+= FULL_DAY_HOUR;
                            break;

                        case 1:
                            EMPLOYEE_WEGES = this.calculateEmployeeDailyWeges(EMPLOYEE_WEGES_PER_HOUR, PARTTIME_HOUR);
                            HOURS+= PARTTIME_HOUR;
                            break;

                        default:
                        break;
                    }
                    break;

                case 1:
                    EMPLOYEE_WEGES = ABSENT;
                    break;
                }
                employee_Monthly_weges += EMPLOYEE_WEGES;
                countDays++;
           
            }
        Console.WriteLine("total weges=" + employee_Monthly_weges + "days=" + countDays + "hours=" + HOURS);
        return employee_Monthly_weges;
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
        employeeWeges emp = new employeeWeges();
        int MONTHLY_WEGES= emp.monthlyWeges(EMPLOYEE_WEGES_PER_HOUR, FULL_DAY_HOUR, PARTTIME_HOUR, ABSENT);
        Console.WriteLine(MONTHLY_WEGES);
      
    }
}