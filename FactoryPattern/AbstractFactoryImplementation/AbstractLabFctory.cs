namespace FactoryPattern.AbstractFactoryImplementation
{
    public  abstract class AbstractLabFctory
    {
        public abstract ILabFctory GetResult();
        public ILabFctory GetLabInstance()
        {
            return this.GetResult();
        }
    }

    public class OmegaLabFactory : AbstractLabFctory
    {
        public override ILabFctory GetResult()
        {
            ILabFctory labFctory = new Omega();
            return labFctory;
        }
    }

    public class CRLLabFactory : AbstractLabFctory
    {
        public override ILabFctory GetResult()
        {
            ILabFctory labFctory = new CRLLab();
            return labFctory;
        }
    }

    public interface ILabFctory
    {
        string GeneratedResult();
    }

    public class CRLLab : ILabFctory
    {
        public string GeneratedResult()
        {
            return "CRLLab";
        }
    }

    public class Omega : ILabFctory
    {
        public string GeneratedResult()
        {
            return "Omega";
        }
    }
}
