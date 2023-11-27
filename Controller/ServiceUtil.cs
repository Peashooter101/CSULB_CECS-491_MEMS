namespace MEMS
{
    public static class ServiceUtil
    {
        public static readonly DatabaseContext dbContext = DatabaseContext.GetInstance();
        public static MachineService machineService = new MachineService(dbContext);
        public static ChangeLogService changeLogService = new ChangeLogService((dbContext));
        public static MaintenanceReminderService MaintenanceReminderService = new MaintenanceReminderService(dbContext);
        public static LoginService LoginService = new LoginService();
        public static UserRoleService UserRoleService = new UserRoleService(dbContext);
        public static ClientService ClientService = new ClientService(dbContext);
    }
}