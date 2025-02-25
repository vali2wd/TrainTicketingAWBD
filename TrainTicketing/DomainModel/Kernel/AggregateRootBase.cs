namespace TrainTicketing.DomainModel.Kernel
{
    public class AggregateRootBase : Entity, IAggregateRoot
    {
        private int _versionId;

        public void IncreaseVersion()
        {
            _versionId++;
        }
    }
}