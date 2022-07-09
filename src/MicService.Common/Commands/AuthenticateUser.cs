namespace MicService.Common.Commands
{
    public class AuthenticateUser:ICommand
    {
        public string Email { get; set; }
        public string Pasword { get; set; }
    }
}