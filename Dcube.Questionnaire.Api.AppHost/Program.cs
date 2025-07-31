var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DCube_Questionnaire_Api>("DCube-Questionnaire-Api");

builder.Build().Run();