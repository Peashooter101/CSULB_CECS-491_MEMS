namespace MEMS
{
    public enum Type
    {
        CreateBusinessLocation = 0,
        DeleteBusinessLocation = 1,
        AddBuilding = 2,
        RemoveBuilding = 3,
        
        CreateBuilding = 10,
        DeleteBuilding = 11,
        ModifyBuildingName = 12,
        
        CreateMachine = 20,
        DeleteMachine = 21,
        ModifyMachineName = 22,
        ModifyManufacturer = 23,
        ModifyZone = 24,
        ModifyIsActive = 25,
        ModifyContactId = 26,
        ModifyMaintenanceScheduleId = 27,
        ModifyBuildingId = 28,
        
        CreateMaintenanceEntry = 30,
        DeleteMaintenanceEntry = 31,
        ModifyMaintenanceType = 32,
        ModifySeverity = 33,
        ModifyMaintenanceEntryDescription = 34,
        
        CreateMaintenanceSchedule = 41,
        DeleteMaintenanceSchedule = 42,
        ModifyMaintenanceSchedule = 43,
        
        CreateUserRole = 50,
        DeleteUserRole = 51,
        ModifyTitle = 52,
        AddUser = 53,
        RemoveUser = 54,
        
        CreateUser = 60,
        DeleteUser = 61,
        AddUserLocationId = 62,
        RemoveUserLocationId = 63,
        ModifyUserName = 64,
        ModifyUserEmail = 65,
        ModifyUserPassword = 66,
        ModifyUserSalt = 67,
        
        CreateContact = 70,
        DeleteContact = 71,
        ModifyContactName = 72,
        ModifyContactEmail = 73,
        ModifyContactPhone = 74,
        ModifyContactBusinessLocation = 75
    }
}