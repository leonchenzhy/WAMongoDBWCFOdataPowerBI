//------------------------------------------------------------------------------
// <copyright file="WebDataService.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using MongoDB.OData;
using MongoDB.Driver;
using System.ServiceModel;
using MongoDB.Bson.Serialization;

[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
public class OdataWcfDataService : MongoDataService<FAAObjects.OdataFAAObjects>
{
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(DataServiceConfiguration config)
    {
        // MongoDataService<T> has a method that pre-configures some stuff for you...
        Configure(config);

        // Set these as necessary
        config.SetEntitySetAccessRule("*", EntitySetRights.All);
        config.SetServiceOperationAccessRule("*", ServiceOperationRights.AllRead);
        config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        config.UseVerboseErrors = true;
    }

    protected override MongoServer CreateMongoServer()
    {
        return MongoServer.Create("<your MongoDBconnection String Goes Here - Example: mongodb://URL:27017>");
    }
}
