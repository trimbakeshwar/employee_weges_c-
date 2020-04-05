using System;
using System.Collections.Generic;
using System.Text;

namespace employeeComputation
{
    public class employeeWeges : weges
    {
        static private int EMPLOYEE_WEGES = 0;
        static private int employee_Monthly_weges = 0;
        static private int countDays = 0;
        static private int WORKING_DAYS = 20;
        private int HOURS = 0;
        static private int TOTAL_MONTHLY_HOUR = 100;
        static private int EMPLOYEE_WEGES_PER_HOUR = 20;
        static  int FULL_DAY_HOUR = 8;
        static  int PARTTIME_HOUR = 4;
        static private int ABSENT = 0;
        /*randome genrate randomly 1 or 0
         * and assign to checkattendance
         * in the c0ndition check if checkattendance is 0
         * return 0
         * or checkattendance is 1 
         * then return 1
         * */
        // check employee present or absent
        public int checkAttendance() 
        {
            Random attendance = new Random();
            int checkAttendance = attendance.Next(2);
            if (checkAttendance == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        //  it calculate fullday weges
         

        public int calculateEmployeeDailyWeges(int workingHours)
        {
            return EMPLOYEE_WEGES_PER_HOUR * workingHours;
        }
        /*first check employee present
         * by calling checkattendance 
         * it return 0 or 1
         * if return 0 it takes full day hours
         * if return 1 it take half day hours
         * return hours for calculaating monthly hours
         * */
        public int getWorkingHours() // working hours 
        {
            int PARTTIME_OR_FULLTIME = 0;
            PARTTIME_OR_FULLTIME = this.checkAttendance();
            if(PARTTIME_OR_FULLTIME==0)
            {
                HOURS = FULL_DAY_HOUR;
                return HOURS;
            }
            else
            {
                HOURS = PARTTIME_HOUR;
                return HOURS;
            }
           
        }
        /*
         * in monthly weges loop can be repeted till it reches 20 time or 100 hours
         * if any onne condition satisfy 
         * then breakloop
         * employee present or absent check by checkattendance function
         * return 0 or 1 
         * if return 0 then calculating totalworkinghours, employee weges'
         * and store in dictionary daily basis
         * if checkattendance is return 1 then employee is absent store in dictionary
         * return monthly weges
         * */
        //calculate monthly weges
        public int monthlyWeges(Dictionary<String, int> dictionary)
        {
            int EMPLOYEE_PRESENT_OR_ABSENT = 0;
            int totalHours = 0;
            int workingHours = 0;
            while (countDays != WORKING_DAYS && totalHours != TOTAL_MONTHLY_HOUR)
            {
                EMPLOYEE_PRESENT_OR_ABSENT = this.checkAttendance();
                switch (EMPLOYEE_PRESENT_OR_ABSENT)
                {
                    case 0:
                        workingHours = getWorkingHours();//take working hours from this function
                        Console.WriteLine(workingHours);
                        totalHours += workingHours;//add daily hours in total monthly hours
                        EMPLOYEE_WEGES = this.calculateEmployeeDailyWeges(workingHours);

                        break;

                    case 1:
                        EMPLOYEE_WEGES = ABSENT;
                        break;
                    default:
                        break;
                }

                countDays++;//coutnt days
                dictionary[$"day {countDays}"] = EMPLOYEE_WEGES;//store daily weges in dictionary
                employee_Monthly_weges += EMPLOYEE_WEGES;//calculate monthly weges
            }

            return employee_Monthly_weges;
        }
    }
}
