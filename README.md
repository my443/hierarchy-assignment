# Hierarchy Assignment WebApp

The purpose of this web app is to allow a user to assign a parent-child relationship for different entities. Entities could be people (in the example of a who-reports-to-who structure) or it could be positions (in the case of an org-chart structure.)

## Notes
The connection string for the database is: 
```Server=CENTRAL;Database=HierarchyAssignmentWebAppContext;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;```

You have to include ```TrustServerCertificate=True;``` or else it complains about incompatible SSL connections.