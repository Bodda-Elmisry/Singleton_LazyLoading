using SingletonDPLazyLoading;

var employeeLogger = SingletonLogger.instance();

employeeLogger.Log("Employee added");

var saleryLogger = SingletonLogger.instance();
saleryLogger.Log("Salery calculated");