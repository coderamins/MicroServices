namespace MicService.Common.Commands
{
    public interface IAuthenticatedCommand:ICommand
    {
         Guid UserId {get;set;}
    }
}