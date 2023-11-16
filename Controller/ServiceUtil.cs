namespace MEMS
{
    public static class ServiceUtil
    {
        public static readonly DatabaseContext dbContext = DatabaseContext.GetInstance();
        public static MachineService machineService = new MachineService(dbContext);
        public static ChangeLogService changeLogService = new ChangeLogService((dbContext));
        public static BusinessLocationService businessLocationService = new BusinessLocationService((dbContext));
    }
}