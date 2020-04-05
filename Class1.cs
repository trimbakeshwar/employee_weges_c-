using System;
using System.Collections.Generic;
using System.Text;

namespace employeeComputation
{
    public interface weges
    {
        int checkAttendance();
        int calculateEmployeeDailyWeges(int workingHours);
        public int getWorkingHours();
        public int monthlyWeges(Dictionary<String, int> dictionary);
    }
}
