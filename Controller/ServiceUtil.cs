namespace MEMS
{
    public static class ServiceUtil
    {
        public static readonly DatabaseContext dbContext = DatabaseContext.GetInstance();
        public static MachineService machineService = new MachineService(dbContext);
    }
}