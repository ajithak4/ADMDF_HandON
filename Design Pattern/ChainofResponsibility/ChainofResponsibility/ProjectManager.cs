using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    public class ProjectManager : ILeaveRequestHandler
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
            if (obj.LeaveDays < 6)
                Console.WriteLine("Leave approved by ProjectManager");
            else
            {
                Console.WriteLine("Leave request approved  by ProjectManager and  passed to HR\n");
                NextHandler = new HR();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}
