var builder = DistributedApplication.CreateBuilder(args);

var mongo = builder.AddMongoDB("mongo");
var mongodb = mongo.AddDatabase("mongodb");

builder.AddProject<Projects.Aspire_MongoDBSample_RESTful>("aspire-mongodbsample-restful").WithReference(mongodb);

builder.Build().Run();
