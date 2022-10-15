using System;

namespace Interview.SOLID.InterfaceSegregation.BadImp;

internal class Manager : ILead
{
    public void AssginTask()
    {
    }

    public void CreateSubTask()
    {
    }

    public void WorkOnTask()
    {
        throw new Exception("Manager can't work on Task");
    }
}
