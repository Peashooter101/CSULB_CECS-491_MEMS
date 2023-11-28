namespace MEMS
{
    public static class ServiceUtil
    {
        public static DatabaseContext dbContext;
        public static MachineService machineService;
        public static ChangeLogService changeLogService;
        public static MaintenanceReminderService MaintenanceReminderService;
        public static LoginService LoginService;
        public static UserRoleService UserRoleService;
        public static ClientService ClientService;

        public static void init()
        {
        machineService = new MachineService(dbContext);
        changeLogService = new ChangeLogService((dbContext));
        MaintenanceReminderService = new MaintenanceReminderService(dbContext);
        LoginService = new LoginService();
        UserRoleService = new UserRoleService(dbContext);
        ClientService = new ClientService(dbContext);
        }
    }
}