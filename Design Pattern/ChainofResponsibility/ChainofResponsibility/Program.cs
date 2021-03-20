using System;

namespace ChainofResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			LeaveRequest obj = new LeaveRequest() { LeaveDays = 10, Employee = "EmpName" };
			ILeaveRequestHandler leave = new SuperVisor();
			leave.HandleRequest(obj);

			Console.ReadLine();
		}
	}
}
