using MicService.Common.Commands;

namespace MicService.Common.RabbitMQ
{
    public static class Extentions
    {
        public static Task WithCommandHandlerAsync<TCommand>(this IBusClient bus,
        ICommandHandler<TCommand> handler)
    }
}