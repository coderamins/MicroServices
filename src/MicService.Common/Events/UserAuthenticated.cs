namespace MicService.Common.Events
{
    public class UserAuthenticated
    {
        public string? Email { get; set; }

        protected UserAuthenticated(){
            
        }

        public UserAuthenticated(string email){
            Email=email;
        }
    }
}