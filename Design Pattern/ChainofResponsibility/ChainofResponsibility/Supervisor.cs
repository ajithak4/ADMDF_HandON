using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    class SuperVisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get
            {
                return nextHandler;
            }
            set
            {
                nextHandler = value;
            }
        }
        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 4)
                Console.WriteLine("Leave approved by SuperVisor");
            else
            {
                Console.WriteLine("Leave request approved by Supervisor and  passed to ProjectManager\n");

                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(obj);

            }
        }


    }
}
