using Noei.BPMS.Domain;

namespace Noei.BPMS.Data.Repositories;

public class WorkflowRepository : RepositoryBase<Workflow>, IWorkflowRepository
{
    public WorkflowRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
    {

    }
}

public interface IWorkflowRepository : Repository<Workflow>
{

}

