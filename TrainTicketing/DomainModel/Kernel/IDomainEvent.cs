using System;

namespace TrainTicketing.DomainModel.Kernel
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }
}