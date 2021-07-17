namespace ConsoleDI
{
    public class WorkerService
    {
        private readonly IService _service;

        public WorkerService(IService service)
        {
            _service = service;
        }

        public void Test()
        {
            _service.Test();
        }
    }
}
