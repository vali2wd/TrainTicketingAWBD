namespace TrainTicketing.DomainModel.Kernel
{
    public interface IAggregateRoot
    {
        void IncreaseVersion();
    }
}