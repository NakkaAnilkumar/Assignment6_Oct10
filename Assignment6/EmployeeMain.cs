using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Assignment6
{
    public class EmployeeMain
    {
        static void Main()
        {
            var employee = new EmployeeLibrary.Employee();

            // Subscribe to the LeaveRequested event
            employee.LeaveRequested += LeaveRequestedHandler;

            Console.WriteLine($"Initial leaves: {employee.Leaves}");
            Console.WriteLine("Enter the number of days for leave:");
            if (int.TryParse(Console.ReadLine(), out int requestedLeaves))
            {
                employee.ApplyForLeave(requestedLeaves);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadLine();
        }

        // Event handler for LeaveRequested
        static void LeaveRequestedHandler(int remainingLeaves)
        {
            Console.WriteLine($"Leaves granted. Remaining leaves: {remainingLeaves}");

        }
    }

}
