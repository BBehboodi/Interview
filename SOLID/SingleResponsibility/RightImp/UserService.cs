using System.ComponentModel.DataAnnotations;

namespace Interview.SOLID.SingleResponsibility.RightImp;

internal class UserService
{
    private readonly EmailService _emailService;

    public UserService(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void Register(string email, string password)
    {
        if (!_emailService.Validate(email))
        {
            throw new ValidationException("Email is not valid");
        }

        _emailService.Send(email, subject: "Registration", "You are registered.");
    }
}
