namespace MicService.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; }
        public Guid UserId {get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }

        protected ActivityCreated(){

        }

        public ActivityCreated(Guid id,Guid userId,
        string category,string name,
        string description,DateTime createdAt)
        {
            this.Id=id;
            this.Category=category;
            this.Name=name;
            this.Description=description;
            this.CreatedAt=createdAt;
        }
    }
}