using System;
using System.ComponentModel.DataAnnotations;

namespace Interview.SOLID.SingleResponsibility.BadImp;

public class UserService
{
    public void Register(string email, string password)
    {
        if (!ValidateEmail(email))
        {
            throw new ValidationException("Email is not valid");
        }

        SendEmail(email, subject: "Registration", "You are registered.");
    }

    public bool ValidateEmail(string email)
    {
        throw new NotImplementedException();
    }

    public void SendEmail(string email, string subject, string content)
    {
        throw new NotImplementedException();
    }
}