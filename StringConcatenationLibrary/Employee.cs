using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        // Define a delegate for leave events
        public delegate void LeaveEventHandler(int remainingLeaves);

        // Define the LeaveRequested event using the delegate
        public event LeaveEventHandler LeaveRequested;

        // Property for leaves with an initial value of 10
        public int Leaves { get; private set; } = 10;

        // Method to apply for leave
        public void ApplyForLeave(int requestedLeaves)
        {
            if (requestedLeaves <= Leaves)
            {
                Leaves -= requestedLeaves;

                // Trigger the LeaveRequested event
                OnLeaveRequested(Leaves);
            }
            else
            {
                Console.WriteLine("Insufficient leaves available.");
            }
        }

        // Helper method to trigger the LeaveRequested event
        protected virtual void OnLeaveRequested(int remainingLeaves)
        {
            LeaveRequested?.Invoke(remainingLeaves);
        }
    }

}
