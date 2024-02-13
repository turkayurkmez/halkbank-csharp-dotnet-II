namespace LifeTimeOFDI.Models
{
    public interface IGuidGenerator
    {
        Guid Guid { get; }
    }

    public interface ISingletonGuid : IGuidGenerator { }
    public interface ITransientGuid : IGuidGenerator { }
    public interface IScopedGuid : IGuidGenerator { }

    public class SingletonGuid : ISingletonGuid
    {

        public Guid Guid { get; }

        public SingletonGuid()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class TransientGuid : ITransientGuid
    {
        public Guid Guid { get; }
        public TransientGuid()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class ScopedGuid : IScopedGuid
    {
        public Guid Guid { get; }
        public ScopedGuid()
        {
            Guid = Guid.NewGuid();
        }
    }


    public class GuidService
    {
        public ISingletonGuid SingletonGuid { get; set; }
        public ITransientGuid TransientGuid { get; set; }
        public IScopedGuid ScopedGuid { get; set; }

        public GuidService(ISingletonGuid singletonGuid, ITransientGuid transientGuid, IScopedGuid scopedGuid)
        {
            SingletonGuid = singletonGuid;
            TransientGuid = transientGuid;
            ScopedGuid = scopedGuid;
        }


    }
}
